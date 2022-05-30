using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DTO.Request;
using ToDoList.DTO.Response;

namespace ToDoList.BusinessLogic.Interface
{
    public interface IToDoItemService
    {
        Task<Response<ToDoItemResponseDTO>> AssignTaskAsync(ToDoItemsRequestDTO ToDoItemRequest, string adminId);
        Task<Response<UpdateToDoItemResponseDTO>> UpdateAssignedTaskAsync(UpdateToDoItemRequestDTO updateToDoItem);
        Task<Response<string>> DeleteAssignedTaskByIdAsync(DeleteRequestDTO assignedtask, string adminId);
        Task<Response<CompletedTaskResponseDTO>> CompletedTask(string id);

    }
}
