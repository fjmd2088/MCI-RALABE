using System;
using System.IO;
using System.Windows.Forms;

namespace encriptador_ralabe
{
    public partial class Form1 : Form
    {
        private const string DEFAULT_PASSWORD = "RalabeSecureKey2024"; // Contraseña por defecto

        public Form1()
        {
            InitializeComponent();
        }

        // ========== ENCRIPTAR ==========

        private void BtnSelectFileEncrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos SQL (*.sql)|*.sql|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Seleccionar archivo SQL para encriptar";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePathEncrypt.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtnProcessEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilePathEncrypt.Text))
            {
                MessageBox.Show("Por favor selecciona un archivo SQL.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(txtFilePathEncrypt.Text))
            {
                MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilePathEncrypt.Clear();
                return;
            }

            // Deshabilitar botones durante el proceso
            btnSelectFileEncrypt.Enabled = false;
            btnProcessEncrypt.Enabled = false;

            try
            {
                string inputPath = txtFilePathEncrypt.Text;
                string inputFileName = Path.GetFileNameWithoutExtension(inputPath);

                // Diálogo para guardar archivo encriptado
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos RALABE (*.ralabe)|*.ralabe|Todos los archivos (*.*)|*.*";
                    saveFileDialog.Title = "Guardar archivo encriptado como";
                    saveFileDialog.FileName = $"{inputFileName}.ralabe";
                    saveFileDialog.InitialDirectory = Path.GetDirectoryName(inputPath);

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        UpdateStatus("Operación cancelada");
                        return;
                    }

                    string outputPath = saveFileDialog.FileName;

                    UpdateStatus("Encriptando archivo...");
                    Application.DoEvents();

                    FileSecurity.EncryptFile(inputPath, outputPath, "Ralab2025");

                    UpdateStatus($"Archivo encriptado correctamente: {outputPath}");
                    MessageBox.Show($"Archivo encriptado exitosamente.\n\nGuardado en: {outputPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar textbox después de éxito
                    txtFilePathEncrypt.Clear();
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("Error al encriptar.");
                MessageBox.Show($"Error al encriptar el archivo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Habilitar botones nuevamente
                btnSelectFileEncrypt.Enabled = true;
                btnProcessEncrypt.Enabled = true;
            }
        }

        // ========== DESENCRIPTAR ==========

        private void BtnSelectFileDecrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos RALABE (*.ralabe)|*.ralabe|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Seleccionar archivo .RALABE para desencriptar";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePathDecrypt.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtnProcessDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilePathDecrypt.Text))
            {
                MessageBox.Show("Por favor selecciona un archivo .RALABE.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(txtFilePathDecrypt.Text))
            {
                MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilePathDecrypt.Clear();
                return;
            }

            // Deshabilitar botones durante el proceso
            btnSelectFileDecrypt.Enabled = false;
            btnProcessDecrypt.Enabled = false;

            try
            {
                string inputPath = txtFilePathDecrypt.Text;
                string inputFileName = Path.GetFileNameWithoutExtension(inputPath);

                // Diálogo para guardar archivo desencriptado
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos SQL (*.sql)|*.sql|Todos los archivos (*.*)|*.*";
                    saveFileDialog.Title = "Guardar archivo desencriptado como";
                    saveFileDialog.FileName = $"{inputFileName}.sql";
                    saveFileDialog.InitialDirectory = Path.GetDirectoryName(inputPath);

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        UpdateStatus("Operación cancelada");
                        return;
                    }

                    string outputPath = saveFileDialog.FileName;

                    UpdateStatus("Desencriptando archivo...");
                    Application.DoEvents();

                    FileSecurity.DecryptFile(inputPath, outputPath, "Ralab2025");

                    UpdateStatus($"Archivo desencriptado correctamente: {outputPath}");
                    MessageBox.Show($"Archivo desencriptado exitosamente.\n\nGuardado en: {outputPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar textbox después de éxito
                    txtFilePathDecrypt.Clear();
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("Error al desencriptar.");
                MessageBox.Show($"Error al desencriptar el archivo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Habilitar botones nuevamente
                btnSelectFileDecrypt.Enabled = true;
                btnProcessDecrypt.Enabled = true;
            }
        }

        // ========== UTILIDADES ==========

        private void UpdateStatus(string message)
        {
            toolStripStatusLabel.Text = message;
        }
    }
}
