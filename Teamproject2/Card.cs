using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamproject2
{
    // ( private < protected < internal _헌 프로젝트 안에서만 접근 가능 < public )
    public class Card   // ( public으로 했을 땐 다른 프로젝트에서도 사용 가능 )
    {
        public Card(int no, bool isKwang)
        {
            _no = no;
            IsKwang = isKwang;
        }

        private int _no;    // 자바의 기본 접근자와 다름
        public int No { get { return _no; } }
        
        public bool IsKwang { get; }

        public override string ToString()
        {
            if (IsKwang)
                return _no + "K";
            else
                return _no.ToString();
        }
    }
}
