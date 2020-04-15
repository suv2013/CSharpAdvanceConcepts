using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Computation computation = new Computation() { Title = "Print File" };
            DoComputation doComputation = new DoComputation();

            MailService mailService = new MailService();
            MessageService messageService = new MessageService();

            doComputation.Computed += mailService.OnComputed;
            doComputation.Computed += messageService.OnComputed;

            doComputation.Compute(computation);
        }
    }
}
