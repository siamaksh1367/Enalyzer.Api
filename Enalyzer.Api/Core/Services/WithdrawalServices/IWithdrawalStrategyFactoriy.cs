namespace Enalyzer.Api.Core.Services.WithdrawalServices
{
    public interface IWithdrawalStrategyFactory<T>
    {
        IEnumerable<IWithdrawalOperator<T>> GetWithdrawalStrategies();
    }
}
