# 📘 Manual de Usuario - Encriptador RALABE

## 👋 Bienvenida

¡Hola! Te damos la bienvenida a **Encriptador RALABE**, tu aliado para proteger la información más valiosa de tu empresa: **tus bases de datos**.

Este manual te guiará paso a paso para que uses la aplicación de forma segura y eficiente.

---

## 🎯 ¿Qué es Encriptador RALABE?

Encriptador RALABE es una aplicación que **protege archivos SQL (bases de datos)** mediante encriptación militar. Piensa en ella como una **caja fuerte digital** para tus archivos.

### ¿Cuándo la necesitas?

✅ Hacer respaldos seguros de bases de datos  
✅ Compartir archivos SQL por email sin riesgos  
✅ Almacenar datos sensibles en la nube  
✅ Cumplir con regulaciones de privacidad de datos  
✅ Proteger información financiera o médica  

---

## 🔒 Contexto de Seguridad

### ¿Por qué es importante?

La información en una base de datos es **valiosa y sensible**. Si alguien accede a tu archivo SQL sin protección, puede:

- Leer información de clientes
- Ver datos financieros
- Modificar registros
- Robar secretos comerciales

**La encriptación evita todo esto.**

### Niveles de Seguridad

```
❌ RIESGO ALTO:
   Archivo SQL sin protección
   (Cualquiera puede leerlo)

⚠️  RIESGO MEDIO:
   Archivo con contraseña básica
   (Vulnerable a ataques)

✅ RIESGO BAJO:
   Archivo RALABE con este aplicativo
   (Encriptación militar, prácticamente inviolable)
```

---

## 📋 Requisitos Previos

Antes de usar la aplicación, asegúrate de tener:

- **Windows 7 o superior** (cualquier versión moderna)
- **Acceso a tus archivos SQL**
- **Espacio en disco** suficiente (mínimo 1.5x el tamaño de tu archivo)
- **Tiempo** (5-10 minutos para aprender)

---

## 🚀 Primeros Pasos

### 1. Abre la Aplicación

1. Haz doble clic en `encriptador_ralabe.exe`
2. La ventana principal se abrirá
3. Verás dos pestañas: **Encriptar** y **Desencriptar**

```
┌─────────────────────────────────────────────────────┐
│ Encriptador RALABE                          [_][□][X]│
├─────────────────────────────────────────────────────┤
│ [Encriptar]    [Desencriptar]                        │
├─────────────────────────────────────────────────────┤
│                                                      │
│  (Contenido de la pestaña)                          │
│                                                      │
│                                                      │
├─────────────────────────────────────────────────────┤
│ Estado: Listo                                        │
└─────────────────────────────────────────────────────┘
```

---

## 🔐 Encriptar un Archivo SQL

### Escenario: Hacer Respaldo Seguro

Tienes una base de datos importante (`clientes.sql`) y quieres hacer un respaldo protegido.

### Paso a Paso

#### **Paso 1: Selecciona tu archivo SQL**

1. Asegúrate de estar en la pestaña **"Encriptar"**
2. Haz clic en el botón **"Seleccionar"**
3. Se abrirá una ventana de explorador de archivos

```
┌─ Selecciona archivo SQL ─────────────────────┐
│                                              │
│ 📁 Mi PC                                    │
│   ├─ 📂 Documentos                          │
│   │  ├─ 📄 clientes.sql          ← AQUÍ     │
│   │  ├─ 📄 productos.sql                    │
│   │  └─ 📄 pedidos.sql                      │
│   └─ 📂 Descargas                           │
│                                              │
│                   [Cancelar]  [Abrir]       │
└──────────────────────────────────────────────┘
```

#### **Paso 2: Busca tu archivo SQL**

- Navega por tu computadora
- Busca archivos con extensión `.sql`
- Puedes buscar en:
  - Carpeta de Documentos
  - Carpeta de Descargas
  - Carpeta del proyecto
  - Unidad externa (USB, disco externo)

#### **Paso 3: Haz clic en "Abrir"**

```
Verás en la pantalla:
┌──────────────────────────────────┐
│ Archivo SQL:                     │
│ C:\Documentos\clientes.sql       │ ← Tu archivo
│                                  │
│ [Seleccionar] [Procesar]         │
└──────────────────────────────────┘
```

#### **Paso 4: Haz clic en "Procesar (Encriptar)"**

1. Se abrirá una nueva ventana: **"Guardar archivo encriptado como"**
2. Elige dónde guardar el archivo protegido
3. El nombre sugerido será `clientes.ralabe` (extensión automática)

```
┌─ Guardar archivo como ───────────────────┐
│                                          │
│ Nombre: clientes        [.ralabe]        │
│                                          │
│ Ubicación: C:\Documentos    ↓            │
│                                          │
│             [Cancelar]  [Guardar]        │
└──────────────────────────────────────────┘
```

#### **Paso 5: Elige la ubicación y haz clic "Guardar"**

Opciones recomendadas para guardar:
- **Misma carpeta** que el original
- **Carpeta específica para backups**
- **Unidad externa (USB, disco externo)**
- **Almacenamiento en la nube** (OneDrive, Google Drive)

#### **Paso 6: Espera a que termine**

```
Estado: Encriptando archivo...

⏳ (La barra de estado muestra el progreso)
```

⏱️ **Tiempo esperado:**
- Archivo 1-10MB: < 1 segundo
- Archivo 10-100MB: 1-3 segundos
- Archivo > 100MB: depende de tu disco

#### **Paso 7: Confirma el éxito**

Se mostrará un mensaje:

```
┌────────────────────────────────────────┐
│ ✅ Éxito                               │
├────────────────────────────────────────┤
│ Archivo encriptado exitosamente.       │
│                                        │
│ Guardado en:                           │
│ C:\Documentos\clientes.ralabe          │
│                                        │
│              [Aceptar]                 │
└────────────────────────────────────────┘
```

### 🎉 ¡Listo!

Tu archivo está protegido. El TextBox se habrá limpiado automáticamente, indicando que el proceso terminó correctamente.

---

## 🔓 Desencriptar un Archivo RALABE

### Escenario: Restaurar Backup Seguro

Tienes un archivo encriptado (`clientes.ralabe`) y necesitas acceder a su contenido.

### Paso a Paso

#### **Paso 1: Ve a la pestaña "Desencriptar"**

Haz clic en la pestaña **"Desencriptar"** en la parte superior de la ventana.

#### **Paso 2: Selecciona tu archivo RALABE**

1. Haz clic en el botón **"Seleccionar"**
2. Se abrirá el explorador de archivos
3. Busca tu archivo con extensión `.ralabe`

```
┌─ Selecciona archivo RALABE ──────────────┐
│                                          │
│ 📁 Mi PC                                │
│   ├─ 📂 Documentos                      │
│   │  ├─ 📄 clientes.ralabe    ← AQUÍ    │
│   │  └─ 📄 productos.ralabe             │
│   └─ 📂 Descargas                       │
│                                          │
│                [Cancelar]  [Abrir]      │
└──────────────────────────────────────────┘
```

#### **Paso 3: Haz clic en "Abrir"**

```
Verás en la pantalla:
┌──────────────────────────────────────┐
│ Archivo .RALABE:                     │
│ C:\Documentos\clientes.ralabe        │ ← Tu archivo
│                                      │
│ [Seleccionar] [Restaurar a SQL]      │
└──────────────────────────────────────┘
```

#### **Paso 4: Haz clic en "Restaurar a SQL"**

1. Se abrirá la ventana **"Guardar archivo desencriptado como"**
2. Elige dónde guardar el archivo restaurado
3. El nombre sugerido será `clientes.sql`

```
┌─ Guardar archivo como ───────────────────┐
│                                          │
│ Nombre: clientes        [.sql]           │
│                                          │
│ Ubicación: C:\Documentos    ↓            │
│                                          │
│             [Cancelar]  [Guardar]        │
└──────────────────────────────────────────┘
```

#### **Paso 5: Personaliza el nombre si es necesario**

Ejemplos útiles de nombres:
- `clientes_restaurado.sql`
- `clientes_2024.sql`
- `clientes_backup_25mar2024.sql`

#### **Paso 6: Haz clic "Guardar"**

#### **Paso 7: Espera a que termine**

```
Estado: Desencriptando archivo...

⏳ (El proceso puede tomar unos segundos)
```

#### **Paso 8: Confirma el éxito**

Se mostrará un mensaje:

```
┌────────────────────────────────────────┐
│ ✅ Éxito                               │
├────────────────────────────────────────┤
│ Archivo desencriptado exitosamente.    │
│                                        │
│ Guardado en:                           │
│ C:\Documentos\clientes_restaurado.sql  │
│                                        │
│              [Aceptar]                 │
└────────────────────────────────────────┘
```

### 🎉 ¡Listo!

Ya puedes usar tu archivo SQL normalmente.

---

## 📋 Mejores Prácticas

### ✅ HAGA

#### 1. **Haz Respaldos Regulares**
```
Ejemplo de estrategia:
- Lunes: Respaldo semanal (encriptado)
- Miércoles: Respaldo medio (encriptado)
- Viernes: Respaldo final de semana (encriptado)

Nombres recomendados:
📦 backup_lun_18mar2024.ralabe
📦 backup_mié_20mar2024.ralabe
📦 backup_vie_22mar2024.ralabe
```

#### 2. **Prueba tus Restauros**
```
Cada mes:
1. Encripta un archivo
2. Desencripta el archivo
3. Verifica que contenga datos correctos

Esto garantiza que tu backup funciona.
```

#### 3. **Almacena en Múltiples Ubicaciones**
```
Distribuye tus backups:
- 1 copia en tu computadora
- 1 copia en USB externo (en tu casa)
- 1 copia en la nube (OneDrive, Google Drive)
- 1 copia en servidor de la empresa

Razón: Si algo ocurre en una ubicación,
tienes copias en otras.
```

#### 4. **Etiqueta tus Archivos Claramente**
```
✅ BIEN:
   backup_clientes_15mar2024_v2.ralabe
   respaldo_productos_2024.ralabe

❌ EVITA:
   backup.ralabe
   archivo.ralabe
   datos1.ralabe
```

#### 5. **Documenta tu Estrategia**
```
Crea un archivo de texto:

PLAN DE BACKUPS
===============
Frecuencia: Semanal (viernes 6 PM)
Bases de datos: clientes, productos, pedidos
Ubicación principal: D:\Backups\
Ubicación secundaria: E:\USB_Backup\
Ubicación nube: OneDrive\Backups\

Última copia: 22 de marzo de 2024
Siguiente copia: 29 de marzo de 2024
```

### ❌ EVITE

#### 1. **NO dejes archivos sin proteger**
```
❌ RIESGO:
   backup_clientes.sql (en tu escritorio)
   Cualquiera que acceda a tu PC lo ve

✅ SEGURO:
   backup_clientes.ralabe (en tu escritorio)
   Solo quien tiene la contraseña lo abre
```

#### 2. **NO olvides dónde guardaste los archivos**
```
❌ Problema:
   "¿Dónde guardé el backup?"
   "No lo encuentro"

✅ Solución:
   Crea una carpeta especial: C:\MisBackups\
   Siempre guarda allí
```

#### 3. **NO descartes el archivo original inmediatamente**
```
❌ Riesgo:
   Encripto archivo.sql → Guardo como archivo.ralabe
   Borro archivo.sql inmediatamente
   Si algo sale mal: pérdida total

✅ Mejor:
   Encripto archivo.sql → Guardo como archivo.ralabe
   Dejo pasar 1 semana
   Verifico que archivo.ralabe se abre correctamente
   Recién entonces borro archivo.sql
```

#### 4. **NO compartas la contraseña fácilmente**
```
❌ Inseguro:
   Contraseña en un post-it en tu monitor
   Contraseña en un email sin encriptar
   Contraseña compartida públicamente

✅ Seguro:
   Contraseña guardada en un gestor seguro
   Compartida personalmente si es necesario
   Cambiada regularmente
```

#### 5. **NO mezcles versiones antiguas y nuevas**
```
❌ Confusión:
   archivo_v1.ralabe (antiguo)
   archivo_v2.ralabe (nuevo)
   ¿Cuál es el más reciente?

✅ Claro:
   archivo_22mar2024.ralabe
   archivo_29mar2024.ralabe
   (Fecha en el nombre)
```

---

## 🆘 Solución de Problemas

### Problema: "El archivo no existe"

**Causa**: La ruta que seleccionaste ya no existe

**Soluciones**:
1. Verifica que el archivo no fue eliminado
2. Busca el archivo en tu computadora nuevamente
3. Revisa si está en una carpeta diferente

### Problema: "La contraseña puede ser incorrecta"

**Causa**: Intentaste desencriptar con contraseña incorrecta

**Soluciones**:
1. Verifica la contraseña (letras mayúsculas/minúsculas importan)
2. Asegúrate de usar la contraseña correcta del sistema
3. Contacta a tu administrador si no la recuerdas

### Problema: "Acceso denegado"

**Causa**: Permisos insuficientes para acceder al archivo

**Soluciones**:
1. Mueve el archivo a una carpeta con permisos
2. Ejecuta la aplicación como administrador (click derecho → Ejecutar como administrador)
3. Comprueba que no tengas el archivo abierto en otra aplicación

### Problema: "El archivo encriptado es inválido"

**Causa**: El archivo está corrupto o no fue creado por esta aplicación

**Soluciones**:
1. Intenta con otro archivo .ralabe
2. Verifica que sea un archivo generado por Encriptador RALABE
3. Si es un backup antiguo, podría estar corrupto (usa otro backup)

### Problema: El proceso es muy lento

**Causa**: Archivo muy grande o disco lento

**Soluciones**:
1. Es normal para archivos > 500MB
2. Cierra otras aplicaciones que usen el disco
3. Considera usar un disco SSD más rápido

---

## 📊 Casos de Uso

### Caso 1: Pequeña Empresa (1-5 usuarios)

```
ESCENARIO:
Tienes una tienda con base de datos de 50MB

ESTRATEGIA:
1. Cada viernes: Encriptar copia de la semana
2. Guardar en carpeta: C:\Backups\
3. Copiar a USB mensualmente
4. Guardar USB en caja de seguridad

PROTECCIÓN: ⭐⭐⭐⭐⭐ (Excelente)
```

### Caso 2: Profesional Independiente

```
ESCENARIO:
Eres consultor con clientes confidenciales

ESTRATEGIA:
1. Encriptar archivos de cada cliente
2. Guardar con nombre: cliente_nombre.ralabe
3. Compartir con cliente por email (seguro)
4. Mantener copia personal encriptada

PROTECCIÓN: ⭐⭐⭐⭐⭐ (Excelente)
```

### Caso 3: Empresa Grande (100+ usuarios)

```
ESCENARIO:
Múltiples bases de datos críticas

ESTRATEGIA:
1. Backup automático cada noche
2. Encriptar diariamente
3. Distribuir: Local + USB + Nube
4. Verificar restauro semanal
5. Documentar todo

PROTECCIÓN: ⭐⭐⭐⭐⭐ (Excelente)
```

---

## 🔄 Flujo de Trabajo Típico

### Día 1: Primeros Pasos

```
1. Instala la aplicación
2. Lee este manual
3. Practica con un archivo de prueba pequeño
4. Encripta → Desencripta
5. Verifica que funciona correctamente
```

### Semana 1: Aplicación Real

```
1. Encripta tu primera base de datos importante
2. Guarda en una ubicación segura
3. Toma nota de dónde la guardaste
4. Documenta la contraseña de forma segura
```

### Mes 1: Operación Normal

```
1. Encripta regularmente (semanal/diaria según necesidad)
2. Prueba restaurar al menos una copia
3. Verifica integridad del archivo restaurado
4. Mantén registro de los backups
```

### Mes 2+: Rutina Establecida

```
1. Encriptación automática de rutina
2. Distribución de copias en múltiples ubicaciones
3. Pruebas periódicas de restauro
4. Documentación actualizada
5. Confianza en tu sistema de protección
```

---

## 💡 Consejos Útiles

### Teclado

| Acción | Método |
|--------|--------|
| Abrir archivo | Click derecho en archivo → Abrir con |
| Ver extensiones | Explorador → Ver → Extensiones de archivo |
| Buscar archivo | Windows + S (escribe nombre del archivo) |

### Nomenclatura

```
Buena estructura de nombres:

[Tipo]_[Nombre]_[Fecha]_[Versión].ralabe

Ejemplos:
- backup_clientes_20240322_v1.ralabe
- respaldo_productos_20240322_v1.ralabe
- datos_empleados_20240322_v1.ralabe
```

### Carpetas Recomendadas

```
C:\
├─ MisBackups\           ← Principal
│  ├─ 2024\
│  │  ├─ Marzo/
│  │  ├─ Abril/
│  │  └─ ...
│  └─ 2025/
│
├─ Documentos/           ← Para trabajos actuales
└─ Descargas/            ← Descarga temporal
```

---

## 📞 Ayuda Rápida

### ¿Dónde están mis archivos?

Presiona `Windows + E` para abrir el Explorador de Archivos.

### ¿Cómo cambio de usuario?

La contraseña es del sistema. Contacta a tu administrador.

### ¿Qué hago si perdí mi archivo?

Busca en:
1. Papelera de Reciclaje
2. Búsqueda de Windows (`.ralabe`)
3. Unidades externas conectadas
4. Carpeta de respaldo

### ¿Es seguro compartir archivos .ralabe?

✅ **SÍ** - Es completamente seguro.

Sin la contraseña correcta, nadie puede verlo.

---

## 🎓 Preguntas Frecuentes

**P: ¿Qué pasa si pierdo mi archivo .ralabe?**  
R: Es como perder una caja fuerte física. Si lo borraste, se fue. Por eso es importante mantener múltiples copias.

**P: ¿Puedo cambiar la contraseña?**  
R: La contraseña del sistema es fija. No se puede cambiar desde la aplicación.

**P: ¿Qué tan segura es la encriptación?**  
R: Usa encriptación militar (AES-256). Tardaría billones de años en romperla con fuerza bruta.

**P: ¿Puedo abrir un archivo .ralabe en otra computadora?**  
R: Sí, siempre que instales esta aplicación y uses la contraseña correcta.

**P: ¿Qué pasa si se interrumpe el proceso?**  
R: La aplicación lo detecta y elimina el archivo incompleto automáticamente.

**P: ¿Funciona con archivos que no son SQL?**  
R: Sí, funciona con cualquier tipo de archivo, no solo SQL.

---

## 🏁 Conclusión

Encriptador RALABE es tu herramienta para mantener segura la información más valiosa de tu negocio.

### Recuerda:

✅ Encripta regularmente  
✅ Guarda en múltiples ubicaciones  
✅ Prueba restaurar regularmente  
✅ Documenta todo  
✅ Mantén la contraseña segura  

### Tu Información Está Protegida

Con Encriptador RALABE, puedes dormir tranquilo sabiendo que tu base de datos está protegida con encriptación de nivel militar.

---

## 📞 Soporte

**Si tienes dudas:**
- Consulta la documentación técnica
- Contacta a tu administrador de sistemas
- Revisa la sección de Solución de Problemas

---

**¡Gracias por usar Encriptador RALABE!**

**Versión**: 1.0  
**Fecha de creación**: 2024  
**Lenguaje**: Español México  

---

**Última actualización**: 2024
