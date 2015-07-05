using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args) {
            #region Заданные условиями задачи интервалы координат
            const float minX = -1;
            const float maxX = 1;
            const float minY = -1;
            const float maxY = 1;
            #endregion

            #region Ввод значений пользователем
            var x = EnterValue("Введите координатное значение X: ");
            var y = EnterValue("Введите координатное значение Y: ");
            #endregion

            #region Проверка выполнения условий задачи
            if (x >= minX && x <= maxX && y >= minY && y <= maxY)
                Console.WriteLine("Указанные координаты входят в заданный диапазон X,Y");
            else
                Console.WriteLine("Указанные координаты НЕ входят в заданный диапазон X,Y");
            Console.WriteLine("Спасибо! Нажмите кнопку для завершения программы.");
            Console.ReadKey();
            #endregion
        }

        /// <summary>
        /// Функция реализует ввод корректного значения типа float пользователем
        /// </summary>
        /// <param name="promptText">Текст требования формата значения вводимого пользователем</param>
        /// <returns></returns>
        private static float EnterValue(string promptText) {
            var result = 0f;

            var isInvalidValue = true;    //  Переменная выполняет роль контрольного значения для управления завершением цикла
            while (isInvalidValue)
            {  //  Цикл повторяется до тех пор, пока не будет введено допустимое значение
                Console.Write(promptText);
                var value = Console.ReadLine(); //  Получаем значение вводимое пользователем в консоли в виде строки
                Console.WriteLine();    //  Перевод строки после пользовательского ввода
                try {
                    result = float.Parse(value); //  Используем конвертирование строкового значения во float
                                                 //  В случае ошибки конвертирования строки во float, 
                                                 //сообщаем пользователю об ошибке ввода значения
                    isInvalidValue = false;
                }
                catch (Exception ex) {
                    Console.WriteLine("ОШИБКА ВВОДА! {0}", ex.Message);
                }
            }

            return result;
        }
    }
}
