using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Interface;
using Курсовая.Models;

namespace Курсовая.Interface
{
    // Интерфейс презентера главной формы
    public interface IMainPresenter
    {
        void AddProductToBasket(Product product);
        void RemoveProductFromBasket(Product product);
        void PayForBasket();
    }
}
