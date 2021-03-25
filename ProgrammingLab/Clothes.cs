using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingLab
{
    public class Clothes
    {
        private readonly string fabric;//Модель ткани
        private int width;//Ширина ткани
        private int fabricNorm;//Норма расхода

        public int Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    width = value;
                }
            }
        }

        public int FabricNorm
        {
            get { return fabricNorm; }
            set
            {
                if (value >= 0)
                {
                    fabricNorm = value;
                }
            }
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns>Информация об одежде</returns>
        public string OutputInformation() =>
            $"Модель ткани {fabric}, ширина ткани {width} м, норма расхода {fabricNorm} м";

        public Clothes()
        {
            fabric = "None";
            width = 0;
            fabricNorm = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="fabric">Модель</param>
        /// <param name="width">Ширина</param>
        /// <param name="fabricNorm">Норма расхода</param>
        public Clothes(string fabric, int width, int fabricNorm)
        {
            this.fabric = fabric;
            this.width = width;
            this.fabricNorm = fabricNorm;
        }

        /// <summary>
        /// Метод который подсчитывает расход ткани
        /// </summary>
        /// <returns>Расход ткани</returns>
        public int FabricConsumption() => (2 + width) * fabricNorm;
    }
}
