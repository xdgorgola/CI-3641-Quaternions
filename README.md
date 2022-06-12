# CI-3641-Quaternions
Implementación de una librería de cuaterniones en .NET Core 3.1 para la clase CI-3641.

# IMPORTANTE
El **operador & de medida o valor absoluto**, es reemplazado por el operador **!**.

# Cómo usar

1. Incluye la librería en tu proyecto, para esto puedes:
	1. Incluir el archivo **Quaternions.cs** al directorio de tu proyecto.
	2. Incluir la carpeta **QuaternionsLibrary** al directorio de tu proyecto y luego agrega el archivo **QuaternionsLibrary.csproj** como una referencia a tu proyecto (Requiere .NET Core 3.1, más info en **Notas**).
2. Importa el **namespace Quaternions** en donde quieras usar la librería.

# Cómo correr las pruebas unitarias
##  Requisitos
- .NET Core 3.1 SDK
- [ReportGenerator](https://github.com/danielpalme/ReportGenerator "ReportGenerator") para realizar Code Coverage

## Obtener .NET Core 3.1 SDK
Las distintas versiones de .NET Core 3.1 SDK se pueden obtener para todas las plataformas desde este [link](https://dotnet.microsoft.com/en-us/download/dotnet/3.1 "link"). Para este proyecto se usó la versión 3.1.419 del SDK.

## Instalar ReportGenerator (Code Coverage)
ReportGenerator es una herramienta global de .NET y viene en un package de NuGet y se puede instalar ejecutando el siguiende comando (dotnet ya debe estar instalado y en el PATH del sistema):

	dotnet tool install -g dotnet-reportgenerator-globaltool

## Realizar pruebas unitarias
Para únicamente realizar las pruebas unitarias **(sin Code Coverage)**, basta con abrir la carpeta **QuaternionsSolution** del proyecto y correr el siguiente comando:

	dotnet test

Los resultados se muestran en la consola.

## Realizar Code Coverage
Para realizar las pruebas unitarias **con Code Coverage**, basta con abrir la carpeta **QuaternionsSolution** del proyecto y correr el siguiente comando:

	dotnet test --collect:"XPlat Code Coverage"

Los resultados se muestran en la consola junto a un output con el siguiente patrón que indica la ruta a un archivo **coverage.cobertura.xml**.

Para poder obtener un Html con una representación del anánilis, utilice el siguiente comando:

	reportgenerator -reports:"Path\To\TestProject\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html

Siendo el parámetro de **-reports**, el path hacia el archivo **coverage.cobertura.xml** generado anteriormente. Esto generará un directorio de nombre coveragereport con un Html que mostrará los resultados. 

Más info en **De interés**

## Notas
- Aunque el proyecto **QuaternionsLibrary.csproj** hace target a .NET Core 3.1, debido a la sencillez de la librería, debe poder cambiarse a otros frameworks de .NET.

- Arrastrar **Quaternions.cs** a tu proyecto quizás sea la mejor opción, dado a que es código de C# bastante básico y probablemente soportado por múltiples versiones de .NET.

## De interés
- Sobre el comando **dotnet test** https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test

- Más info de cómo usar el Code Coverage https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows

- Repositorio de [ReportGenerator](https://github.com/danielpalme/ReportGenerator "ReportGenerator")

- Como instalar .NET Core en Linux https://docs.microsoft.com/en-us/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website

- [xUnit](https://xunit.net "xUnit") (herramienta de unit testing usada)
