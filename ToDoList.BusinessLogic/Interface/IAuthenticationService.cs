using System.Threading.Tasks;
using ToDoList.DTO.Request;
using ToDoList.DTO.Response;

namespace ToDoList.BusinessLogic.Interface
{
    public interface IAuthenticationService
    {
        Task<Response<LoginUserResponseDTO>> LoginAsync(UserRequestDTO userRequest);
        Task<UserRegistrationResponseDTO> RegisterAsync(UserRegistrationRequestDTO registrationRequest);
    }
}
