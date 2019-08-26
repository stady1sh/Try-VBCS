using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary_CS.C001_010
{
    public class C001
    {

        public enum animal
        {
            dog = 1,
            cat = 2,
            bear = 3,
            monkey = 4
        }

        public void GetValues()
        {

            // 列挙型の定数の値を配列で取得（Array型）
            var values = typeof(animal).GetEnumValues();

            foreach (var value in values)
            {
                MessageBox.Show((string)value);
            }
        }

        public void GetValue()
        {

            int value = (int)animal.bear;

            MessageBox.Show(value.ToString());

        }

        public void GetNames()
        {

            // 列挙型の名前を配列で取得（String型）
            string[] values = typeof(animal).GetEnumNames();

            foreach (var value in values)
            {
                MessageBox.Show(value);
            }


        }

        public void GetName()
        {

            // 列挙型から、値の一致する名前を取得（String型）
            string value = typeof(animal).GetEnumName(animal.bear);

            MessageBox.Show(value);

        }


    }
}
