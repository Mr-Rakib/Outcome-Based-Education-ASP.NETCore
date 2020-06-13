$(document).ready(

    function () {
        $('#edit-package-modal').on('show.bs.modal',
            function (e) {
                var packageId = $(e.relatedTarget).attr('data-id');
                $('#packageUpdModal').load('/Packages/GetPackagesById?id=' + packageId);
            });

        $('#delete-package-modal').on('show.bs.modal',
            function (e) {
                var packageId = $(e.relatedTarget).attr('data-id');
                $('#packageDeleteModal').load('/Packages/DeletePackagesById?id=' + packageId);
            });


        $('#company-email-modal').on('show.bs.modal',
            function (e) {
                var employeeId = $(e.relatedTarget).attr('data-id');
                $('#companyEmailModal').load('/Company/SendEmail?id=' + employeeId);
            });

        $('#view-details-modal').on('show.bs.modal',
            function (e) {
                var employeeId = $(e.relatedTarget).attr('data-id');
                $('#viewdetailsmodal').load('/Company/Details?id=' + employeeId);
            });

    },



);

