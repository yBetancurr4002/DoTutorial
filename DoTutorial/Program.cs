using System;

namespace CSharpBasicsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TUTORIAL INTERACTIVO DE C# institución universitaria pascual bravo - CONCEPTOS BÁSICOS ===\n");
            Console.WriteLine("¡Bienvenido! Este tutorial te guiará paso a paso por los conceptos fundamentales de C#\n");

            // Menú principal
            bool continuar = true;
            while (continuar)
            {
                MostrarMenuPrincipal();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        TutorialVariables();
                        break;
                    case "2":
                        TutorialOperadores();
                        break;
                    case "3":
                        TutorialCondicionales();
                        break;
                    case "4":
                        TutorialBucles();
                        break;
                    case "5":
                        TutorialMetodos();
                        break;
                    case "6":
                        TutorialArreglos();
                        break;
                    case "7":
                        RepasarTodo();
                        break;
                    case "0":
                        Console.WriteLine("\n¡Gracias por usar el tutorial! ¡Sigue practicando C#!");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida. Por favor, selecciona una opción del 0 al 7.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void MostrarMenuPrincipal()
        {
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Variables y Tipos de Datos");
            Console.WriteLine("2. Operadores");
            Console.WriteLine("3. Estructuras Condicionales");
            Console.WriteLine("4. Bucles y Ciclos");
            Console.WriteLine("5. Métodos y Funciones");
            Console.WriteLine("6. Arreglos");
            Console.WriteLine("7. Repaso General");
            Console.WriteLine("0. Salir");
            Console.Write("\nSelecciona una opción: ");
        }

        #region 1. TUTORIAL DE VARIABLES
        static void TutorialVariables()
        {
            Console.Clear();
            Console.WriteLine("=== 1. VARIABLES Y TIPOS DE DATOS ===\n");

            // Explicación teórica
            Console.WriteLine("📚 Conceptos:");
            Console.WriteLine("Las variables son espacios de memoria que almacenan datos.");
            Console.WriteLine("En C#, cada variable debe tener un tipo de dato específico.\n");

            Console.WriteLine("🔹 Tipos básicos más comunes:");
            Console.WriteLine("• int: números enteros (ej: 42, -15, 0)");
            Console.WriteLine("• double: números decimales (ej: 3.14, -2.5)");
            Console.WriteLine("• string: texto (ej: \"Hola mundo\") \n |  Nota: se usan comillas dobles, no exclusivo para letras, con este tipo de dato se pueden almacenar números, caracteres especiales, espacios, etc.");
            Console.WriteLine("• bool: verdadero o falso (true/false)");
            Console.WriteLine("• char: un solo carácter (ej: 'A', '5')\n Nota: se debe usar comillas simples" );

            // Demostración práctica
            Console.WriteLine("💡 DEMOSTRACIÓN:");

            // Declaración e inicialización
            int edad = 25;
            double altura = 1.75;
            string nombre = "Ana";
            bool esEstudiante = true;
            char inicial = 'A';

            // Ejemplo por consola
            Console.WriteLine($"int edad = {edad};");
            Console.WriteLine($"double altura = {altura};");
            Console.WriteLine($"string nombre = \"{nombre}\";");
            Console.WriteLine($"bool esEstudiante = {esEstudiante};");
            Console.WriteLine($"char inicial = '{inicial}';\n");

            // Ejercicio interactivo
            Console.WriteLine("🎯 EJERCICIO PRÁCTICO:");
            Console.WriteLine("Vamos a crear variables con tus datos personales:\n");

            try
            {
                Console.Write("Ingresa tu nombre: ");
                string tuNombre = Console.ReadLine();

                Console.Write("Ingresa tu edad: ");
                int tuEdad = int.Parse(Console.ReadLine()); // por defecto ReadLine() solo recibe tipos str, por esto debemos parsear

                Console.Write("Ingresa tu estatura (ej: 1.70): ");
                double tuEstatura = double.Parse(Console.ReadLine());

                Console.Write("¿Eres estudiante? (true/false): ");
                bool eresTuEstudiante = bool.Parse(Console.ReadLine());

                Console.WriteLine("\n✅ ¡Excelente! Has creado las siguientes variables:");
                Console.WriteLine($"string tuNombre = \"{tuNombre}\";");
                Console.WriteLine($"int tuEdad = {tuEdad};");
                Console.WriteLine($"double tuEstatura = {tuEstatura};");
                Console.WriteLine($"bool eresTuEstudiante = {eresTuEstudiante};");

                // Demostrar conversiones
                Console.WriteLine("\n🔄 CONVERSIONES DE TIPOS:");
                Console.WriteLine($"Tu edad como string: \"{tuEdad.ToString()}\"");
                Console.WriteLine($"Tu estatura como int (truncada): {(int)tuEstatura}");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Ingresaste un formato incorrecto. Inténtalo de nuevo.");
            }

            Console.WriteLine("\n📋 RESUMEN CLAVE:");
            Console.WriteLine("• Siempre declara el tipo antes del nombre: 'int numero'");
            Console.WriteLine("• Usa nombres descriptivos para las variables");
            Console.WriteLine("• Los string van entre comillas dobles: \"texto\"");
            Console.WriteLine("• Los char van entre comillas simples: 'c'");
            Console.WriteLine("• Puedes convertir tipos usando Parse() o casting");
        }
        #endregion

        #region 2. TUTORIAL DE OPERADORES
        static void TutorialOperadores()
        {
            Console.Clear();
            Console.WriteLine("=== 2. OPERADORES ===\n");

            Console.WriteLine("📚 TEORÍA:");
            Console.WriteLine("Los operadores nos permiten realizar operaciones con variables y valores.\n");

            // Operadores aritméticos
            Console.WriteLine("🔢 OPERADORES ARITMÉTICOS:");
            int a = 10, b = 3;
            Console.WriteLine($"Sean a = {a} y b = {b}:");
            Console.WriteLine($"• Suma (+): {a} + {b} = {a + b}");
            Console.WriteLine($"• Resta (-): {a} - {b} = {a - b}");
            Console.WriteLine($"• Multiplicación (*): {a} * {b} = {a * b}");
            Console.WriteLine($"• División (/): {a} / {b} = {a / b}");
            Console.WriteLine($"• Módulo (%): {a} % {b} = {a % b} (resto de la división)\n");

            // Operadores de comparación
            Console.WriteLine("⚖️ OPERADORES DE COMPARACIÓN:");
            Console.WriteLine($"• Igual (==): {a} == {b} = {a == b}");
            Console.WriteLine($"• Diferente (!=): {a} != {b} = {a != b}");
            Console.WriteLine($"• Mayor (>): {a} > {b} = {a > b}");
            Console.WriteLine($"• Menor (<): {a} < {b} = {a < b}");
            Console.WriteLine($"• Mayor o igual (>=): {a} >= {b} = {a >= b}");
            Console.WriteLine($"• Menor o igual (<=): {a} <= {b} = {a <= b}\n");

            // Operadores lógicos
            Console.WriteLine("🧠 OPERADORES LÓGICOS:");
            bool x = true, y = false;
            Console.WriteLine($"Sean x = {x} y y = {y}:");
            Console.WriteLine($"• AND (&&): {x} && {y} = {x && y}");
            Console.WriteLine($"• OR (||): {x} || {y} = {x || y}");
            Console.WriteLine($"• NOT (!): !{x} = {!x}\n");

            // Ejercicio de calculadora
            Console.WriteLine("🎯 EJERCICIO: CALCULADORA BÁSICA");
            try
            {
                Console.Write("Ingresa el primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"• {num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"• {num1} - {num2} = {num1 - num2}");
                Console.WriteLine($"• {num1} * {num2} = {num1 * num2}");

                if (num2 != 0)
                    Console.WriteLine($"• {num1} / {num2} = {num1 / num2:F2}");
                else
                    Console.WriteLine("• División por cero no permitida");

                Console.WriteLine("\nComparaciones:");
                Console.WriteLine($"• {num1} > {num2}: {num1 > num2}");
                Console.WriteLine($"• {num1} == {num2}: {num1 == num2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Ingresa números válidos.");
            }

            Console.WriteLine("\n📋 RESUMEN CLAVE:");
            Console.WriteLine("• Aritméticos: +, -, *, /, %");
            Console.WriteLine("• Comparación: ==, !=, >, <, >=, <=");
            Console.WriteLine("• Lógicos: && (AND), || (OR), ! (NOT)");
            Console.WriteLine("• El resultado de comparaciones es siempre bool");
        }
        #endregion

        #region 3. TUTORIAL DE CONDICIONALES
        static void TutorialCondicionales()
        {
            Console.Clear();
            Console.WriteLine("=== 3. ESTRUCTURAS CONDICIONALES ===\n");

            Console.WriteLine("📚 TEORÍA:");
            Console.WriteLine("Las estructuras condicionales nos permiten ejecutar código diferente");
            Console.WriteLine("según se cumplan o no ciertas condiciones.\n");

            Console.WriteLine("🔀 TIPOS DE CONDICIONALES:");
            Console.WriteLine("• if: ejecuta código si la condición es verdadera");
            Console.WriteLine("• else: ejecuta código si la condición es falsa");
            Console.WriteLine("• else if: evalúa múltiples condiciones");
            Console.WriteLine("• switch: compara una variable con múltiples valores\n");

            // Demostración con if/else
            Console.WriteLine("💡 DEMOSTRACIÓN - IF/ELSE:");
            int temperatura = 25;
            Console.WriteLine($"Temperatura actual: {temperatura}°C\n");

            if (temperatura > 30)
            {
                Console.WriteLine("Hace calor 🌞");
            }
            else if (temperatura > 20)
            {
                Console.WriteLine("Temperatura agradable 😊");
            }
            else if (temperatura > 10)
            {
                Console.WriteLine("Hace fresco 🍂");
            }
            else
            {
                Console.WriteLine("Hace frío ❄️");
            }

            // Demostración con switch
            Console.WriteLine("\n💡 DEMOSTRACIÓN - SWITCH:");
            int diaSemana = 3;
            string nombreDia;

            switch (diaSemana)
            {
                case 1:
                    nombreDia = "Lunes";
                    break;
                case 2:
                    nombreDia = "Martes";
                    break;
                case 3:
                    nombreDia = "Miércoles";
                    break;
                case 4:
                    nombreDia = "Jueves";
                    break;
                case 5:
                    nombreDia = "Viernes";
                    break;
                case 6:
                    nombreDia = "Sábado";
                    break;
                case 7:
                    nombreDia = "Domingo";
                    break;
                default:
                    nombreDia = "Día inválido";
                    break;
            }
            Console.WriteLine($"El día {diaSemana} corresponde a: {nombreDia}");

            // Ejercicio interactivo
            Console.WriteLine("\n🎯 EJERCICIO: CALIFICADOR DE NOTAS");
            try
            {
                Console.Write("\nIngresa tu calificación (0-100): ");
                int nota = int.Parse(Console.ReadLine());

                Console.WriteLine("\nResultado:");

                if (nota >= 90 && nota <= 100)
                {
                    Console.WriteLine($"Calificación: {nota} - ¡EXCELENTE! 🌟");
                    Console.WriteLine("Has obtenido una A");
                }
                else if (nota >= 80)
                {
                    Console.WriteLine($"Calificación: {nota} - MUY BUENO 👍");
                    Console.WriteLine("Has obtenido una B");
                }
                else if (nota >= 70)
                {
                    Console.WriteLine($"Calificación: {nota} - BUENO 😊");
                    Console.WriteLine("Has obtenido una C");
                }
                else if (nota >= 60)
                {
                    Console.WriteLine($"Calificación: {nota} - SUFICIENTE 😐");
                    Console.WriteLine("Has obtenido una D");
                }
                else if (nota >= 0)
                {
                    Console.WriteLine($"Calificación: {nota} - INSUFICIENTE 😞");
                    Console.WriteLine("Has obtenido una F - Necesitas estudiar más");
                }
                else
                {
                    Console.WriteLine("❌ Calificación inválida. Debe estar entre 0 y 100.");
                }

                // Ejercicio adicional con switch
                Console.WriteLine("\n🎲 BONUS - Selecciona una opción:");
                Console.WriteLine("1. Ver consejos de estudio");
                Console.WriteLine("2. Ver recursos adicionales");
                Console.WriteLine("3. Continuar");
                Console.Write("Tu opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n📚 Consejos de estudio:");
                        Console.WriteLine("• Establece horarios fijos");
                        Console.WriteLine("• Toma descansos regulares");
                        Console.WriteLine("• Practica con ejercicios");
                        break;
                    case "2":
                        Console.WriteLine("\n🔗 Recursos adicionales:");
                        Console.WriteLine("• Documentación oficial de Microsoft");
                        Console.WriteLine("• Tutoriales en línea");
                        Console.WriteLine("• Comunidades de programadores");
                        break;
                    case "3":
                        Console.WriteLine("\n✅ ¡Continuamos!");
                        break;
                    default:
                        Console.WriteLine("\n❌ Opción no válida, pero continuamos...");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Ingresa un número válido.");
            }

            Console.WriteLine("\n📋 RESUMEN CLAVE:");
            Console.WriteLine("• if evalúa condiciones booleanas (true/false)");
            Console.WriteLine("• else if permite múltiples condiciones");
            Console.WriteLine("• switch es útil para comparar una variable con varios valores");
            Console.WriteLine("• Usa && (AND) y || (OR) para combinar condiciones");
            Console.WriteLine("• No olvides el 'break' en cada case del switch");
        }
        #endregion

        #region 4. TUTORIAL DE BUCLES
        static void TutorialBucles()
        {
            Console.Clear();
            Console.WriteLine("=== 4. BUCLES Y CICLOS ===\n");

            Console.WriteLine("📚 TEORÍA:");
            Console.WriteLine("Los bucles nos permiten repetir código múltiples veces");
            Console.WriteLine("mientras se cumpla una condición.\n");

            Console.WriteLine("🔁 TIPOS DE BUCLES:");
            Console.WriteLine("• for: cuando sabes cuántas veces repetir");
            Console.WriteLine("• while: repite mientras la condición sea verdadera");
            Console.WriteLine("• do-while: ejecuta al menos una vez, luego evalúa");
            Console.WriteLine("• foreach: recorre colecciones/arreglos\n");

            // Demostración FOR
            Console.WriteLine("💡 DEMOSTRACIÓN - BUCLE FOR:");
            Console.WriteLine("Contando del 1 al 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteración {i}");
            }

            // Demostración WHILE
            Console.WriteLine("\n💡 DEMOSTRACIÓN - BUCLE WHILE:");
            Console.WriteLine("Cuenta regresiva desde 5:");
            int contador = 5;
            while (contador > 0)
            {
                Console.WriteLine($"Contador: {contador}");
                contador--; // Equivale a contador = contador - 1
            }
            Console.WriteLine("¡Despegue! 🚀");

            // Demostración DO-WHILE
            Console.WriteLine("\n💡 DEMOSTRACIÓN - DO-WHILE:");
            Console.WriteLine("Este bucle siempre se ejecuta al menos una vez:");
            int numero = 10;
            do
            {
                Console.WriteLine($"Número: {numero}");
                numero += 2; // Equivale a numero = numero + 2
            } while (numero < 15);

            // Demostración FOREACH con arreglo simple
            Console.WriteLine("\n💡 DEMOSTRACIÓN - FOREACH:");
            string[] colores = { "Rojo", "Verde", "Azul", "Amarillo" };
            Console.WriteLine("Colores disponibles:");
            foreach (string color in colores)
            {
                Console.WriteLine($"• {color}");
            }

            // Ejercicio interactivo - Tabla de multiplicar
            Console.WriteLine("\n🎯 EJERCICIO: TABLA DE MULTIPLICAR");
            try
            {
                Console.Write("Ingresa un número para ver su tabla de multiplicar: ");
                int numeroTabla = int.Parse(Console.ReadLine());

                Console.WriteLine($"\n=== TABLA DEL {numeroTabla} ===");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numeroTabla * i;
                    Console.WriteLine($"{numeroTabla} x {i} = {resultado}");
                }

                // Ejercicio adicional - Suma acumulativa
                Console.WriteLine("\n🎯 EJERCICIO ADICIONAL: SUMA ACUMULATIVA");
                Console.Write("¿Hasta qué número quieres sumar? (ej: 5 suma 1+2+3+4+5): ");
                int limite = int.Parse(Console.ReadLine());

                int suma = 0;
                Console.Write("Sumando: ");
                for (int i = 1; i <= limite; i++)
                {
                    suma += i;
                    Console.Write($"{i}");
                    if (i < limite) Console.Write(" + ");
                }
                Console.WriteLine($" = {suma}");

                // Demostrar el mismo resultado con while
                Console.WriteLine("\nComprobación usando WHILE:");
                int j = 1;
                int sumaWhile = 0;
                Console.Write("Sumando: ");
                while (j <= limite)
                {
                    sumaWhile += j;
                    Console.Write($"{j}");
                    if (j < limite) Console.Write(" + ");
                    j++;
                }
                Console.WriteLine($" = {sumaWhile}");

            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Ingresa números válidos.");
            }

            // Ejercicio de validación con do-while
            Console.WriteLine("\n🎯 EJERCICIO: VALIDACIÓN CON DO-WHILE");
            int opcionMenu;
            do
            {
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Opción A");
                Console.WriteLine("2. Opción B");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona (1-3): ");

                try
                {
                    opcionMenu = int.Parse(Console.ReadLine());

                    switch (opcionMenu)
                    {
                        case 1:
                            Console.WriteLine("✅ Seleccionaste Opción A");
                            break;
                        case 2:
                            Console.WriteLine("✅ Seleccionaste Opción B");
                            break;
                        case 3:
                            Console.WriteLine("✅ Saliendo del menú...");
                            break;
                        default:
                            Console.WriteLine("❌ Opción inválida. Intenta de nuevo.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("❌ Error: Ingresa un número válido.");
                    opcionMenu = 0; // Para que continúe el bucle
                }

            } while (opcionMenu < 1 || opcionMenu > 3);

            Console.WriteLine("\n📋 RESUMEN CLAVE:");
            Console.WriteLine("• FOR: for(inicio; condición; incremento) - mejor para contadores");
            Console.WriteLine("• WHILE: while(condición) - repite mientras sea verdadero");
            Console.WriteLine("• DO-WHILE: do{...}while(condición) - ejecuta mínimo una vez");
            Console.WriteLine("• FOREACH: foreach(tipo item in colección) - recorre colecciones");
            Console.WriteLine("• Cuidado con bucles infinitos - siempre modifica la condición");
        }
        #endregion

        #region 5. TUTORIAL DE MÉTODOS
        static void TutorialMetodos()
        {
            Console.Clear();
            Console.WriteLine("=== 5. MÉTODOS Y FUNCIONES ===\n");

            Console.WriteLine("📚 TEORÍA:");
            Console.WriteLine("Los métodos son bloques de código reutilizables que realizan tareas específicas.");
            Console.WriteLine("Nos ayudan a organizar el código y evitar repeticiones.\n");

            Console.WriteLine("🔧 ESTRUCTURA DE UN MÉTODO:");
            Console.WriteLine("modificador tipoRetorno NombreMetodo(parámetros)");
            Console.WriteLine("{");
            Console.WriteLine("    // código del método");
            Console.WriteLine("    return valor; // si retorna algo");
            Console.WriteLine("}\n");

            Console.WriteLine("📝 COMPONENTES:");
            Console.WriteLine("• Modificador: public, private, static, etc.");
            Console.WriteLine("• Tipo de retorno: void (no retorna), int, string, bool, etc.");
            Console.WriteLine("• Nombre: debe ser descriptivo (PascalCase)");
            Console.WriteLine("• Parámetros: datos que recibe el método (opcionales)\n");

            // Demostración de métodos
            Console.WriteLine("💡 DEMOSTRACIONES:");

            // Método sin parámetros ni retorno
            Console.WriteLine("1. Método sin parámetros que no retorna valor:");
            MostrarSaludo();

            // Método con parámetros sin retorno
            Console.WriteLine("\n2. Método con parámetros que no retorna valor:");
            MostrarPersona("Carlos", 28);

            // Método con parámetros y retorno
            Console.WriteLine("\n3. Método con parámetros que retorna valor:");
            int resultado = Sumar(15, 25);
            Console.WriteLine($"Resultado de sumar 15 + 25 = {resultado}");

            // Método con múltiples parámetros y retorno
            Console.WriteLine("\n4. Método más complejo:");
            double promedio = CalcularPromedio(8.5, 9.0, 7.5);
            Console.WriteLine($"Promedio de 8.5, 9.0, 7.5 = {promedio:F2}");

            // Ejercicio interactivo
            Console.WriteLine("\n🎯 EJERCICIO INTERACTIVO:");
            Console.WriteLine("Vamos a usar varios métodos para procesar información:\n");

            try
            {
                Console.Write("Ingresa tu nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingresa tu primer apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("Ingresa tu edad: ");
                int edad = int.Parse(Console.ReadLine());

                // Usar métodos personalizados
                string nombreCompleto = CombinarNombres(nombre, apellido);
                string categoria = ClasificarPorEdad(edad);
                bool esMayorEdad = EsMayorDeEdad(edad);

                Console.WriteLine("\n✅ RESULTADOS USANDO MÉTODOS:");
                Console.WriteLine($"Nombre completo: {nombreCompleto}");
                Console.WriteLine($"Categoría de edad: {categoria}");
                Console.WriteLine($"¿Es mayor de edad?: {esMayorEdad}");

                // Demostrar método con validación
                Console.WriteLine("\n🔢 CALCULADORA CON MÉTODOS:");
                Console.Write("Primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Suma: {RealizarSuma(num1, num2)}");
                Console.WriteLine($"Resta: {RealizarResta(num1, num2)}");
                Console.WriteLine($"Multiplicación: {RealizarMultiplicacion(num1, num2)}");

                string resultadoDivision = RealizarDivision(num1, num2);
                Console.WriteLine($"División: {resultadoDivision}");

            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error en el formato de entrada.");
            }

            Console.WriteLine("\n📋 RESUMEN CLAVE:");
            Console.WriteLine("• Los métodos organizan y reutilizan código");
            Console.WriteLine("• 'void' significa que no retorna valor");
            Console.WriteLine("• 'return' devuelve un valor al código que llama al método");
            Console.WriteLine("• Los parámetros son variables que recibe el método");
            Console.WriteLine("• Un método puede llamar a otros métodos");
            Console.WriteLine("• Nombra métodos con verbos descriptivos (CalcularPromedio, ValidarDatos)");
        }

        // Métodos auxiliares para la demostración
        static void MostrarSaludo()
        {
            Console.WriteLine("¡Hola! Este mensaje viene de un método sin parámetros.");
        }

        static void MostrarPersona(string nombre, int edad)
        {
            Console.WriteLine($"Persona: {nombre}, Edad: {edad} años");
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        static string CombinarNombres(string nombre, string apellido)
        {
            return nombre + " " + apellido;
        }

        static string ClasificarPorEdad(int edad)
        {
            if (edad < 13) return "Niño";
            else if (edad < 18) return "Adolescente";
            else if (edad < 60) return "Adulto";
            else return "Adulto Mayor";
        }

        static bool EsMayorDeEdad(int edad)
        {
            return edad >= 18;
        }

        static double RealizarSuma(double a, double b)
        {
            return a + b;
        }

        static double RealizarResta(double a, double b)
        {
            return a - b;
        }

        static double RealizarMultiplicacion(double a, double b)
        {
            return a * b;
        }

        static string RealizarDivision(double a, double b)
        {
            if (b == 0)
                return "Error: División por cero no permitida";
            else
                return (a / b).ToString("F2");
        }
        #endregion

        #region 6. TUTORIAL DE ARREGLOS
        static void TutorialArreglos()
        {
            Console.Clear();
            Console.WriteLine("=== 6. ARREGLOS (ARRAYS) ===\n");

            Console.WriteLine("📚 TEORÍA:");
            Console.WriteLine("Los arreglos son colecciones de elementos del mismo tipo,");
            Console.WriteLine("almacenados en posiciones consecutivas de memoria.\n");

            Console.WriteLine("📝 CARACTERÍSTICAS:");
            Console.WriteLine("• Todos los elementos son del mismo tipo");
            Console.WriteLine("• Tienen un tamaño fijo definido al crearlos");
            Console.WriteLine("• Se accede a elementos por índice (empezando en 0)");
            Console.WriteLine("• Los índices van de 0 a longitud-1\n");

            // Demostración de declaración e inicialización
            Console.WriteLine("💡 FORMAS DE DECLARAR ARREGLOS:");

            // Forma 1: Declaración con tamaño
            int[] numeros = new int[5]; // Arreglo de 5 enteros (inicializados en 0)
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            Console.WriteLine("1. Declaración con tamaño y asignación individual:");
            Console.WriteLine("int[] numeros = new int[5];");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"numeros[{i}] = {numeros[i]}");
            }

            // Forma 2: Inicialización directa
            Console.WriteLine("\n2. Inicialización directa con valores:");
            string[] frutas = { "Manzana", "Banana", "Naranja", "Uva" };
            Console.WriteLine("string[] frutas = { \"Manzana\", \"Banana\", \"Naranja\", \"Uva\" };");
            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine($"frutas[{i}] = \"{frutas[i]}\"");
            }

            // Forma 3: Inicialización con new
            Console.WriteLine("\n3. Inicialización con 'new':");
            double[] precios = new double[] { 15.50, 22.30, 8.75, 45.20 };
            Console.WriteLine("double[] precios = new double[] { 15.50, 22.30, 8.75, 45.20 };");
            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine($"precios[{i}] = ${precios[i]}");
            }

            // Demostrar propiedades importantes
            Console.WriteLine("\n🔍 PROPIEDADES IMPORTANTES:");
            Console.WriteLine($"• Longitud del arreglo frutas: {frutas.Length}");
            Console.WriteLine($"• Primer elemento: frutas[0] = \"{frutas[0]}\"");
            Console.WriteLine($"• Último elemento: frutas[{frutas.Length - 1}] = \"{frutas[frutas.Length - 1]}\"");

            // Recorrido con foreach
            Console.WriteLine("\n🔄 RECORRIDO CON FOREACH:");
            Console.WriteLine("foreach (string fruta in frutas)");
            Console.WriteLine("{");
            foreach (string fruta in frutas)
            {
                Console.WriteLine($"    Console.WriteLine(\"{fruta}\");");
            }
            Console.WriteLine("}");

            // Ejercicio interactivo - Gestión de calificaciones
            Console.WriteLine("\n🎯 EJERCICIO: SISTEMA DE CALIFICACIONES");
            try
            {
                Console.Write("¿Cuántas calificaciones quieres ingresar? ");
                int cantidadNotas = int.Parse(Console.ReadLine());

                if (cantidadNotas <= 0)
                {
                    Console.WriteLine("❌ Debes ingresar al menos una calificación.");
                    return;
                }

                // Crear arreglo para las calificaciones
                double[] calificaciones = new double[cantidadNotas];

                Console.WriteLine($"\nIngresa {cantidadNotas} calificaciones:");
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    Console.Write($"Calificación {i + 1}: ");
                    calificaciones[i] = double.Parse(Console.ReadLine());
                }

                // Mostrar las calificaciones ingresadas
                Console.WriteLine("\n📊 CALIFICACIONES REGISTRADAS:");
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    Console.WriteLine($"Materia {i + 1}: {calificaciones[i]:F1}");
                }

                // Calcular estadísticas
                double suma = 0;
                double mayor = calificaciones[0];
                double menor = calificaciones[0];

                foreach (double nota in calificaciones)
                {
                    suma += nota;
                    if (nota > mayor) mayor = nota;
                    if (nota < menor) menor = nota;
                }

                double promedio = suma / calificaciones.Length;

                Console.WriteLine("\n📈 ESTADÍSTICAS:");
                Console.WriteLine($"• Total de calificaciones: {calificaciones.Length}");
                Console.WriteLine($"• Suma total: {suma:F1}");
                Console.WriteLine($"• Promedio: {promedio:F2}");
                Console.WriteLine($"• Calificación más alta: {mayor:F1}");
                Console.WriteLine($"• Calificación más baja: {menor:F1}");

                // Clasificar calificaciones
                Console.WriteLine("\n📋 CLASIFICACIÓN:");
                int aprobadas = 0, reprobadas = 0;
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    string estado = calificaciones[i] >= 60 ? "✅ APROBADA" : "❌ REPROBADA";
                    Console.WriteLine($"Materia {i + 1}: {calificaciones[i]:F1} - {estado}");

                    if (calificaciones[i] >= 60) aprobadas++;
                    else reprobadas++;
                }

                Console.WriteLine($"\nRESUMEN: {aprobadas} aprobadas, {reprobadas} reprobadas");

                // Buscar una calificación específica
                Console.WriteLine("\n🔍 BÚSQUEDA:");
                Console.Write("Ingresa una calificación para buscar: ");
                double buscar = double.Parse(Console.ReadLine());

                bool encontrada = false;
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    if (calificaciones[i] == buscar)
                    {
                        Console.WriteLine($"✅ Calificación {buscar} encontrada en la posición {i + 1}");
                        encontrada = true;
                        break;
                    }
                }

                if (!encontrada)
                {
                    Console.WriteLine($"❌ Calificación {buscar} no encontrada");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Error: Ingresa números válidos.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("❌ Error: Índice fuera del rango del arreglo.");
            }

            // Demostración de operaciones comunes
            Console.WriteLine("\n🛠️ OPERACIONES COMUNES CON ARREGLOS:");

            int[] ejemploNumeros = { 5, 2, 8, 1, 9, 3 };
            Console.WriteLine("Arreglo original: [" + string.Join(", ", ejemploNumeros) + "]");

            // Ordenamiento burbuja simple (demostración)
            int[] numerosOrdenados = new int[ejemploNumeros.Length];
            Array.Copy(ejemploNumeros, numerosOrdenados, ejemploNumeros.Length);

            // Ordenamiento usando Array.Sort()
            Array.Sort(numerosOrdenados);
            Console.WriteLine("Arreglo ordenado: [" + string.Join(", ", numerosOrdenados) + "]");

            // Invertir arreglo
            Array.Reverse(numerosOrdenados);
            Console.WriteLine("Arreglo invertido: [" + string.Join(", ", numerosOrdenados) + "]");

            Console.WriteLine("\n📋 RESUMEN CLAVE:");
            Console.WriteLine("• Declaración: tipo[] nombre = new tipo[tamaño];");
            Console.WriteLine("• Inicialización: tipo[] nombre = { valor1, valor2, ... };");
            Console.WriteLine("• Acceso: arreglo[índice] (índices empiezan en 0)");
            Console.WriteLine("• Longitud: arreglo.Length");
            Console.WriteLine("• Recorrido: for (índices) o foreach (elementos)");
            Console.WriteLine("• Cuidado con IndexOutOfRangeException");
            Console.WriteLine("• Métodos útiles: Array.Sort(), Array.Reverse(), Array.Copy()");
        }
        #endregion

        static void RepasarTodo()
        {
            Console.WriteLine("\n🎉 ¡Felicidades por completar todos los tutoriales! 🎉");
            Console.WriteLine("\n📚 Ahora vamos a crear una App de consola, que nos permita explorar estos conceptos en un caso práctico y repasar los elementos vistos...");
            Console.WriteLine(@"
            Simulador de Gestión de Estudiantes
                
                Enfoque: Creemos un proyecto práctico que integra todos los conceptos en un contexto real. Este será una app que nos permita gestionar las notas de los estudiantes, utilizando todos lo aprendido.
                
                ¿Cómo abordaría cada tema?:

                🟢 Variables: Almacenar datos de estudiantes (nombre, edad, calificaciones)
                🟢 Operadores: Calcular promedios, comparar calificaciones
                🟢 Condicionales: Determinar si un estudiante aprueba/reprueba
                🟢 Bucles: Recorrer listas de estudiantes, mostrar menús
                🟢 Métodos: Funciones para agregar, buscar, calcular promedios
                🟢 Arreglos: Almacenar múltiples estudiantes y sus calificaciones
            ");
        }
    }
}