using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatBritainApp.Models
{
    internal class Good
    {
        /// <summary>

        /// Возвращает абсолютный путь к изображению

        /// </summary>

        public string GetPhoto

        {

            get

            {

                if (MainPhoto is null)

                    return null;

                return Directory.GetCurrentDirectory() + @"\Images\" + MainPhoto.Trim();

            }

        }

        /// <summary>

        /// Задает цвет фона товара

        /// </summary>

        public string GetColor
        {
            get
            {
                if (Active)
                    return "#fff";
                else
                    return "#8C8181";
            }
        }
        /// <summary>
        /// Текстовое представление активности товара
        /// </summary>
        public string GetStatus
        {
            get
            {
                if (Active)
                    return "";
                else
                    return "нет в наличии";
            }
        }
        /// <summary>

        /// Возвращает количество дополнительных товаров

        /// </summary>

        public string GetCount
        {
            get
            {
                if (Complects.Count > 0)
                    return $"({Complects.Count})";
                else
                    return "";
            }
        }
        public string GetInfo

        {

            get

            {

                return $"{GoodName} - {Price.ToString("c")} рублей.";

            }

        }
    }
}
