using JPBlazor.Shared.Settings;
using System.Threading.Tasks;
using JPBlazor.Shared.Wrapper;

namespace JPBlazor.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}