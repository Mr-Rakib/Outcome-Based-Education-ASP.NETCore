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
    confirm("Are you sure you want to delete?");
}

$(document).ready(function () {
    $('table.MultipleDataTable').dataTable();
});



$('#view-mission-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewmissionmodal').load('/Academy/DetailsMission?id=' + Id);
    }
);

$('#view-peo-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewpeomodal').load('/Academy/DetailsPEO?id=' + Id);
    }
);

$('#view-plo-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewplomodal').load('/Academy/DetailsPLO?id=' + Id);
    }
);

$('#view-clo-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewclomodal').load('/Academy/DetailsCLO?id=' + Id);
    }
);

$('#view-assessment-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewassessmentmodal').load('/Assessment/DetailsAssessment?id=' + Id);
    }
);


$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});


$('#view-missiontopeo-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewmissiontopeomodal').load('/Mapping/MissionToPEODetails?id=' + Id);
    }
);


$('#view-plotopeo-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewplotopeomodal').load('/Mapping/PLOToPEODetails?id=' + Id);
    }
);


$('#view-clotoplo-modal').on('show.bs.modal',
    function (e) {
        var Id = $(e.relatedTarget).attr('data-id');
        $('#viewclotoplomodal').load('/Mapping/CLOToPLODetails?id=' + Id);
    }
);

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