# 🔷 Solución C# y .NET 9: Algoritmos y Prácticas Académicas

[![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/es-es/dotnet/csharp/)
[![Visual Studio](https://img.shields.io/badge/Visual_Studio-Solution-5C2D91?style=for-the-badge&logo=visual-studio)](https://visualstudio.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg?style=for-the-badge)](LICENSE)

> Solución integral desarrollada en **C# (.NET 9)** que agrupa 13 proyectos de consola independientes bajo una misma solución de Visual Studio (\C#.sln\). Abarca algoritmos de cálculo matemático, lógica de condicionales y prácticas evaluativas de desarrollo de software.

---

## 🏗️ Estructura de la Solución (\C#.sln\)

La solución está organizada en 3 categorías funcionales:

\\\	ext
cshare-ejercicios/
├── C#.sln                                # Archivo de Solución de Visual Studio
├── 📐 Módulo de Cálculo y Geometría:
│   ├── IMC/                              # Cálculo de Índice de Masa Corporal y diagnóstico
│   ├── areaRectangulo/                   # Cálculo de base, altura y superficie
│   ├── perimetroTriangulo/               # Geometría y validación de lados
│   ├── enunciado1Tiempo/                 # Conversión temporal (horas, minutos, segundos)
│   └── enunciado2Media/                  # Cálculo de medias aritméticas y promedios
│
├── 🔀 Módulo de Control de Flujo:
│   ├── claseCondicionales/               # Estructuras if-else y bifurcaciones
│   ├── condicionalesC#/                  # Evaluación de condiciones complejas
│   ├── numeroMayor/                      # Algoritmo de comparación y ordenamiento de máximos
│   └── numeroMultiplo/                   # Operadores de módulo y divisibilidad numérica
│
└── 📋 Módulo de Prácticas Académicas:
    ├── practica1/                        # Práctica evaluativa 1: Entrada/Salida y tipos primitivos
    ├── practica2/                        # Práctica evaluativa 2: Lógica de selección y validación
    ├── practica3/                        # Práctica evaluativa 3: Estructuras repetitivas y acumuladores
    └── practica4/                        # Práctica evaluativa 4: Integración algorítmica modular
\\\

---

## 🚀 Requisitos y Ejecución

### Requisitos previos
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) instalado en tu equipo.

### Compilación y Ejecución por Proyecto (CLI)

Puedes ejecutar cualquier proyecto de la solución directamente desde la raíz utilizando el comando \dotnet run --project\:

\\\ash
# 1. Ejecutar el cálculo de IMC
dotnet run --project IMC

# 2. Ejecutar el cálculo de Área del Rectángulo
dotnet run --project areaRectangulo

# 3. Ejecutar comparación de número mayor
dotnet run --project numeroMayor

# 4. Ejecutar Práctica 4
dotnet run --project practica4
\\\

### Compilar la Solución Completa
\\\ash
dotnet build  C#.sln
\\\

---

## 👨‍💻 Autor
Desarrollado por **[Saúl Alexander Martínez (Luaz)](https://github.com/Luaz2021)** — Estudiante de DAM en la Universidad Europea.