using System.Drawing;

namespace Lab1
{
    public sealed class Singleton
    {

        private static Singleton _instance;
        private static readonly object locker = new object();

        public Color BackColor { get; set; }
        public Color FontColor { get; set; }
        public int MainFormWidth { get; set; }
        public int MainFormHeight { get; set; }

        private Singleton()
        {
            BackColor = Color.White;
            FontColor = Color.Black;
            MainFormWidth = 1256;
            MainFormHeight = 737;
        }

        public static Singleton GetInstance() // потокобезопасная реализация
        {
            if (_instance == null)
            {
                lock (locker) // Оператор lock получает взаимоисключающую блокировку заданного
                              // объекта перед выполнением определенных операторов,
                              // а затем снимает блокировку.
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }

            return _instance;
        }

    }
}
