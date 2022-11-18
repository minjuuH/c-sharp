using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//동일한 네임스페이스
namespace ClassProgrammingExample {
    class clsMyClass {
        private int m_intHeight;

        public int Height {
            get { return m_intHeight; }
            set { 
                if (value >= 10)
                    m_intHeight = value;
            }
        }

        public long AddTwoNumbers(int intNumber1, int intNumber2)
        {
            return intNumber1 + intNumber2;
        }
    }
}
