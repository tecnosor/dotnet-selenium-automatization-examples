# [ENGLISH] 🚀 Example of Automation with Selenium

**Example Development:**

Selenium is a powerful tool designed to automate tests involving user interfaces, such as HTML code on a web page.

The code has been developed in two phases:

- 📝 User actions necessary to leave a comment on Instagram were recorded using Selenium IDE.
- 🧩 The test in Selenium IDE was manually adjusted to correctly capture some reactive elements, refining the automation.
- 🚅 The test was exported to C# (.NET Core).
- 🔧 The code was refactored to meet the desired example, including:
    - Encapsulating the test action to leave a comment in its own class.
    - Adapting the class according to the desired behavior.
    - The program's entry point provides a basic example of automation usage until December 2023.

> ⚠️ **NOTE:** In the future, the way to interact with this use case may change due to possible modifications to Instagram's web user interface.

## 💻 How to Test this Example:

1. **Requirements:**  
    1.1. Google Chrome browser is required for this case. With other browsers, a different approach and modification of `Bot.cs` will be necessary.  
    1.2. Windows operating system is needed (there are alternative solutions for Linux, but they will not be addressed here).  

2. **Download chromedriver:**  
    2.1. Ensure it is compatible with your browser version. You can find the version in Settings -> Chrome Information.  
    2.2. The download link for chromedriver is: [https://googlechromelabs.github.io/chrome-for-testing/](https://googlechromelabs.github.io/chrome-for-testing/)  
    2.3. Attach the executable file (.exe).

3. **Build:**  
   1. (Option 1) With Visual Studio (Community):  
      1. Start Visual Studio.  
      2. Run the application.  
   2. (Option 2) Other IDEs / Code Editors:  
      1. Install the .NET Core runtime.  
      2. Run `dotnet build` (with desired parameters according to the build type **release, debug...**).

## 📝 Authors:
- Alfonso Soria Muñoz
- Tecnosor .SL


# [ESPAÑOL] 🚀 Ejemplo de Automatización con Selenium

**Desarrollo del Ejemplo:**

Selenium es una potente herramienta diseñada para automatizar pruebas que involucran interfaces de usuario, como el código HTML en una página web.

El código se ha desarrollado en dos fases:

- 📝 Se han registrado las acciones de usuario necesarias para realizar un comentario en Instagram utilizando Selenium IDE. Este lo puedes añadir como extensión en tu navegador favorito.
- 🧩 Se ha ajustado manualmente el test en Selenium IDE para obtener correctamente algunos elementos reactivos, perfeccionando la automatización.
- 🚅 El test se ha exportado a C# (.NET Core).
- 🔧 Se ha refactorizado el código para cumplir con el ejemplo deseado, que incluye:
    - Encapsular en una clase propia la acción del test para realizar un comentario.
    - Adaptar la clase según el comportamiento deseado.
    - El punto de entrada del programa presenta un ejemplo básico de uso de la automatización hasta diciembre de 2023.

> ⚠️ **NOTA:** En el futuro, la manera de interactuar con este caso de uso puede cambiar debido a posibles modificaciones en la interfaz de usuario web de Instagram.

## 💻 Cómo Probar este Ejemplo:

1. **Requisitos:**  
    1.1. Se requiere el navegador Chrome para este caso. Con otros navegadores, será necesario otro enfoque y modificar `Bot.cs`.  
    1.2. Se necesita el sistema operativo Windows (hay soluciones alternativas para Linux, pero no se abordarán aquí).  

2. **Descargar chromedriver:**  
    2.1. Asegúrate de que sea compatible con la versión de tu navegador. Puedes encontrar la versión en Configuración -> Información de Chrome.  
    2.2. El enlace de descarga para chromedriver es:   [https://googlechromelabs.github.io/chrome-for-testing/](https://googlechromelabs.github.io/chrome-for-testing/)  
    2.3. Adjunta el archivo ejecutable (.exe).  

3. **Build:**  
   1. (Opción 1) Con Visual Studio (Community)  
      1. Inicia Visual Studio.  
      2. Ejecuta la aplicación.  
   2. (Opción 2) Otros IDEs / Editores de Código:  
      1. Instala el runtime de .NET Core.  
      2. Ejecuta `dotnet build` (con los parámetros deseados según el tipo de build **release, debug...**).  

## 📝 Autores:
- Alfonso Soria Muñoz
- Tecnosor ©

 
MIT License.