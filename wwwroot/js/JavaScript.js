function OpenHeader() {
    document.getElementById("headernav").classList.toggle("active");
}
function Unavailable() {
    alert('Service Not Available');
}
function ActiveConfirmation() {
    confirm('Are you sure to Activate ?');
}

function DeleteConfirmation() {
    var x = confirm("Are you sure you want to delete?");
    if (x)
        return true;
    else
        return false;
}

$(document).ready(function () {
    $('table.MultipleDataTable').dataTable();
});



$('#view-profile-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewprofilemodal').load('/Academy/DetailsMission?id=' + Id);
    }
);

$('#view-edit-modal').on('show.bs.modal',
    function (e) {
        var employeeId = $(e.relatedTarget).attr('data-id');
        $('#vieweditmodal').load('/User/Edit?id=' + employeeId);
    }
);

$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});


var loadFile = function (event) {
    var output = document.getElementById('output');
    output.src = URL.createObjectURL(event.target.files[0]);
    output.onload = function () {
        URL.revokeObjectURL(output.src) // free memory
    }
};

function getFilePath() {
    $('input[type=file]').change(
        function () {
            var filePath = $('#fileUpload').val();
            return filePath;
        }
    );
}