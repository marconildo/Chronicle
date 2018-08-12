using System.Threading.Tasks;

namespace Chronicle
{
    public interface ISagaAsyncAction<in TMessage>
    {
        Task HandleAsync(TMessage message);
        Task CompensateAsync(TMessage message);
    }
}
