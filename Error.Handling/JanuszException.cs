using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error.Handling;

[Serializable]
public class JanuszException : Exception
{
    private const string DefaultMessage = "Janusz thrown an error. Deal with it!";

    public JanuszException() : base(DefaultMessage)
    { }

    public JanuszException(string message) : base(message) { }

    public JanuszException(Exception innerException) : base(DefaultMessage, innerException) { }
}
