namespace Lab5
{
    public static class Utils
    {
        /// <summary>
        /// Возвращает приветственное сообщение
        /// </summary>
        /// <returns>Строка с приветствием</returns>
        public static string HelloMessage()
        {
            return "Добро пожаловать в проект!";
        }

        /// <summary>
        /// Складывает два числа
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Сумма чисел</returns>
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}