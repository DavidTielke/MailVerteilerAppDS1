using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailVerteilerApp
{
    // ### V1
    // + Erweiterbarkeit: 6
    // + Testbarkeit: 2
    // + Wiederverwendbarkeit: 6
    // + AUstauschbarkeit: 4
    // + Wartbarkeit: 2

    // ### V2
    // + Erweiterbarkeit: 2
    // + Testbarkeit: 1
    // + Wiederverwendbarkeit: 1
    // + AUstauschbarkeit: 1
    // + Wartbarkeit: 4

    // ### V4
    // + Erweiterbarkeit: 1
    // + Testbarkeit: 1
    // + Wiederverwendbarkeit: 1
    // + AUstauschbarkeit: 1
    // + Wartbarkeit: 2
    public interface IConfigurator
    {
        TItem Get<TItem>(string key, TItem defaultValue = default);
        void Set(string key, object value);
    }

    // ### V3
    // // + Erweiterbarkeit: 6
    // // + Testbarkeit: 2
    // // + Wiederverwendbarkeit: 6
    // // + AUstauschbarkeit: 4
    // // + Wartbarkeit: 2
}
