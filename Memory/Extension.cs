using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Memory
{
    static class Extension
    {
        public static List<Button> CopyButtons(this List<Button> buttons)
        {
            List<Button> copies = new List<Button>();

            foreach (Button button in buttons)
            {
                Type type = button.GetType();
                ConstructorInfo ctor = type.GetConstructor(new Type[] { });
                Button newBut = ctor.Invoke(new object[] { }) as Button;

                newBut.Tag = button.Tag;
                newBut.Image = button.Image;

                copies.Add(newBut);
            }

            return copies;
        }
    }
}
