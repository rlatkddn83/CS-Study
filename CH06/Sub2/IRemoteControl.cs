using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06.Sub2
{
    internal interface IRemoteControl
    {
        // 인터페이스는 추상 메서드만 갖는다.
        public abstract void PowerOn();
        public abstract void PowerOff();

        public void ChUp(); // abstract생략
        public void ChDown();

        public void SoundUp();
        public void SoundDown();

    }
}
