$(document).ready(function () {
    ShowEmployeeData();
});

function ShowEmployeeData() {
    $.ajax({
        url: '/Ajax/EmployeeList',
        type: 'Get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.EmployeeId + '</td>';
                object += '<td>' + item.Name + '</td>';
                object += '<td>' + item.ProfileImage + '</td>';
                object += '<td>' + item.Gender + '</td>';
                object += '<td>' + item.Department + '</td>';
                object += '<td>' + item.Salary + '</td>';
                object += '<td>' + item.StartDate + '</td>';
                object += '<td>' + item.Notes + '</td>';
                object += '<td><a href="#" class ="btn btn-primary">Edit</a> || <a href="# class ="btn btn-danger">Delete</a></td>';
                object += '<tr>';
                
            });
            $('table_data').html(object);
        },
        error: function () {
            alert("Data can't be fetched");
        }
    });
};

$('#btnAddEmployee').click(function () {
    $('#EmployeeModal').modal('show');
})

function AddEmployee() {
    debugger
    var employeeData = {
        Name: $('#Name').val(),
        ProfileImage: $('#ProfileImage').val(),
        Gender: $('#Gender').val(),
        Department: $('#Department').val(),
        Salary: $('#Salary').val(),
        StartDate: $('#StartDate').val(),
        Notes: $('#Notes').val()
    };

    $.ajax({
        url: '/Ajax/AddEmployee',
        type: 'Post',
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded;charset=utf-8;',
        data: employeeData,
        success: function () {
                alert("Data saved");
        },
        error: function () {
            alert("Error adding employee.");
        }
    });
}

