using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace em.Filter
{
    public delegate void IsClosed();
    public interface IFilterPanelViewModel
    {
        string NewFilterData { get; set; }
        event IsClosed OnClosed;
    }
}
