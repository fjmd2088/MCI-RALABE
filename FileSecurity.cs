using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace encriptador_ralabe
{
    public static class FileSecurity
    {
        private const int SaltSize = 32; // 32 bytes
        private const int KeySize = 32; // 256 bits para AES
        private const int IvSize = 16; // 128 bits para AES
        private const int Iterations = 10000; // Iteraciones PBKDF2
        private const int BufferSize = 8192; // 8KB para FileStream

        /// <summary>
        /// Encripta un archivo usando AES con PBKDF2 y salt
        /// </summary>
        /// <param name="inputPath">Ruta del archivo a encriptar</param>
        /// <param name="outputPath">Ruta del archivo encriptado de salida</param>
        /// <param name="password">Contraseña para derivar la llave</param>
        public static void EncryptFile(string inputPath, string outputPath, string password)
        {
            if (string.IsNullOrWhiteSpace(inputPath) || !File.Exists(inputPath))
                throw new FileNotFoundException("El archivo de entrada no existe.", inputPath);

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña no puede estar vacía.", nameof(password));

            try
            {
                // Generar salt aleatorio
                byte[] salt = new byte[SaltSize];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }

                // Derivar llave usando PBKDF2
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
                {
                    byte[] key = pbkdf2.GetBytes(KeySize);
                    byte[] iv = pbkdf2.GetBytes(IvSize);

                    using (var aes = Aes.Create())
                    {
                        aes.Key = key;
                        aes.IV = iv;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;

                        using (var encryptor = aes.CreateEncryptor())
                        {
                            using (var inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read, BufferSize))
                            using (var outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None, BufferSize))
                            {
                                // Escribir salt en el archivo de salida
                                outputStream.Write(salt, 0, salt.Length);

                                // Usar CryptoStream para encriptar
                                using (var cryptoStream = new CryptoStream(outputStream, encryptor, CryptoStreamMode.Write))
                                {
                                    byte[] buffer = new byte[BufferSize];
                                    int bytesRead;

                                    while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        cryptoStream.Write(buffer, 0, bytesRead);
                                    }

                                    cryptoStream.FlushFinalBlock();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Eliminar archivo de salida si ocurre un error
                if (File.Exists(outputPath))
                {
                    try { File.Delete(outputPath); }
                    catch { }
                }
                throw new InvalidOperationException("Error al encriptar el archivo.", ex);
            }
        }

        /// <summary>
        /// Desencripta un archivo que fue encriptado con EncryptFile filtrando metacomandos de PostgreSQL
        /// </summary>
        /// <param name="inputPath">Ruta del archivo encriptado</param>
        /// <param name="outputPath">Ruta del archivo desencriptado de salida (.sql)</param>
        /// <param name="password">Contraseña para derivar la llave</param>
        public static void DecryptFile(string inputPath, string outputPath, string password)
        {
            if (string.IsNullOrWhiteSpace(inputPath) || !File.Exists(inputPath))
                throw new FileNotFoundException("El archivo de entrada no existe.", inputPath);

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña no puede estar vacía.", nameof(password));

            try
            {
                using (var inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read, FileShare.Read, BufferSize))
                {
                    // Leer el salt del archivo
                    byte[] salt = new byte[SaltSize];
                    int saltBytesRead = inputStream.Read(salt, 0, salt.Length);

                    if (saltBytesRead != SaltSize)
                        throw new InvalidOperationException("El archivo encriptado es inválido: salt incorrecto.");

                    // Derivar la llave usando PBKDF2
                    using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
                    {
                        byte[] key = pbkdf2.GetBytes(KeySize);
                        byte[] iv = pbkdf2.GetBytes(IvSize);

                        using (var aes = Aes.Create())
                        {
                            aes.Key = key;
                            aes.IV = iv;
                            aes.Mode = CipherMode.CBC;
                            aes.Padding = PaddingMode.PKCS7;

                            using (var decryptor = aes.CreateDecryptor())
                            using (var outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None, BufferSize))
                            using (var cryptoStream = new CryptoStream(inputStream, decryptor, CryptoStreamMode.Read))
                            // Se envuelve el CryptoStream en lectores/escritores de texto forzando UTF-8
                            using (var reader = new StreamReader(cryptoStream, Encoding.UTF8))
                            using (var writer = new StreamWriter(outputStream, Encoding.UTF8))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    // Filtrar los metacomandos de sandbox de PostgreSQL 18+
                                    if (line.StartsWith("\\restrict") || line.StartsWith("\\unrestrict"))
                                    {
                                        continue; // Omitir esta línea y pasar a la siguiente
                                    }

                                    writer.WriteLine(line);
                                }
                            }
                        }
                    }
                }
            }
            catch (CryptographicException ex)
            {
                // Eliminar archivo de salida si ocurre un error
                if (File.Exists(outputPath))
                {
                    try { File.Delete(outputPath); }
                    catch { }
                }
                throw new InvalidOperationException("Error al desencriptar el archivo. La contraseña puede ser incorrecta.", ex);
            }
            catch (Exception ex)
            {
                // Eliminar archivo de salida si ocurre un error
                if (File.Exists(outputPath))
                {
                    try { File.Delete(outputPath); }
                    catch { }
                }
                throw new InvalidOperationException("Error al desencriptar el archivo.", ex);
            }
        }
    }
}