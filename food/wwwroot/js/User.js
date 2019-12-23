var dataTable;

$(document).ready(function() {
    loadList();
});

function loadList()
{
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/user",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "fullName", "width": "25%" },
            { "data": "email", "width": "25%" },
            { "data": "phoneNumber", "width": "25%" },

            {
                "data": {id:"id",lockoutEnd:"lockoutEnd"},
                "render": function(data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();
                    if (lockout > today) {
                        //currently user is locked
                        return ` 
                                <div class="text-center">                                
                                <a class="btn btn-white text-black" style="cursor:pointer; width:100px;" onclick=LockUnlock('${data.id}')>                                     
                                <i class="fas fa-lock-open" style="color:red;" ></i> Unclock                                   
                                </a>  </div>
                                `;
                    } else {
                        return ` 
                                <div class="text-center">                                
                                <a class="btn btn-white text-black" style="cursor:pointer; width:100px;" onclick=LockUnlock('${
                            data.id}')>                                     
                                <i class="fas fa-lock" style="color:green;" ></i> Lock                                   
                                </a> 
                                    </div>
                                `;
                    }
                 
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "no data found."
        },
        "width": "100%"
    });
}
function LockUnlock(id) {
  
            $.ajax({
                type: 'POST',
                url: '/api/User',
                data:JSON.stringify(id),
                contentType:"application/json",
                success: function(data) {
                    if (!data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                }
            });
   
}