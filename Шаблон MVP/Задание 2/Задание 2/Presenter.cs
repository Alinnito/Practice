using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Presenter
    {
        private readonly Model model;
        private readonly MainWindow view;

        public Presenter(MainWindow v)
        {
            model = new Model();
            view = v;
            view.Equal += view_Equal;
        }

        void view_Equal(object sender, EventArgs e)
        {
            model.oper = Convert.ToString(view.combobox.Text);
            
            model.firstnum = Convert.ToInt32(view.tbfirst.Text);
            model.secondnum = Convert.ToInt32(view.tbsecond.Text);

            view.res.Content = "= " + model.Res();
        }
    }
}
