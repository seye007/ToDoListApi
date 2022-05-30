using AutoMapper;
using ToDoList.Domain;
using ToDoList.DTO.Request;
using ToDoList.DTO.Response;

namespace ToDoList.DTO.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserRegistrationRequestDTO>().ReverseMap();
            CreateMap<ToDoItem, ToDoItemsRequestDTO>().ReverseMap();
            CreateMap<ToDoItem, ToDoItemResponseDTO>().ReverseMap();
            CreateMap<ToDoItem, UpdateToDoItemRequestDTO>().ReverseMap();
            CreateMap<UpdateToDoItemResponseDTO, ToDoItem>().ReverseMap();
            CreateMap<ActivityLog, DeleteRequestDTO>().ReverseMap();
            CreateMap<UserRegistrationResponseDTO, User>().ReverseMap();
            CreateMap<LoginUserResponseDTO, User>().ReverseMap();
            CreateMap<CompletedTaskResponseDTO, ToDoItem>().ReverseMap();
        }
    }
}
