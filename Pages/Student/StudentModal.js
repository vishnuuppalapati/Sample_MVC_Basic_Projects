//$(function () {
//    var nFTSEOtagService = window.rDLCReports.student.student;

//    var dataTable = $("#StudentsTable").DataTable(abp.libs.datatables.normalizeConfiguration({
//        processing: true,
//        serverSide: true,
//        paging: true,
//        searching: false,
//        scrollX: true,
//        autoWidth: false,
//        scrollCollapse: true,
//        order: [[1, "asc"]],
//        ajax: abp.libs.datatables.createAjax(studentService.getAllList, getFilter),
//        columnDefs: [
//            //{
//                //rowAction: {
//                //    items:
//                //        [
//                            //{
//                            //    text: l("Edit"),
//                            //    visible: abp.auth.isGranted('Marketplace.NFTSEOtags.Edit'),
//                            //    action: function (data) {
//                            //        editModal.open({
//                            //         id: data.record.nFTSEOtag.id
//                            //         });
//                            //    }
//                            //},
//                            //{
//                            //    text: l("Delete"),
//                            //    visible: abp.auth.isGranted('Marketplace.NFTSEOtags.Delete'),
//                            //    confirmMessage: function () {
//                            //        return l("DeleteConfirmationMessage");
//                            //    },
//                            //    action: function (data) {
//                            //        nFTSEOtagService.delete(data.record.nftseOtag.id)
//                            //            .then(function () {
//                            //                abp.notify.info(l("SuccessfullyDeleted"));
//                            //                dataTable.ajax.reload();
//                            //            });
//                            //    }
//                            //}
//            //            ]
//            //    }
//            //},
//            //{
//            //    data: "nftseOtag.tagName"
//            //},
//            //{ data: "nftseOtag.tagvalue" },
//            //{
//            //    render: function (data, text, row) {
//            //        if (row.nftMaster != null) {
//            //            return row.nftMaster.name;
//            //        }
//            //        else {
//            //            return "-- NAN --";
//            //        }

//            //    }
//            //},
//            //{
//            //    render: function (data, text, row) {
//            //        if (row.category != null) {
//            //            return row.category.name;
//            //        }
//            //        else {
//            //            return "-- NAN --";
//            //        }

//            //    }
//            //},
//            //{
//            //    render: function (data, text, row) {
//            //        if (row.collection != null) {
//            //            return row.collection.name;
//            //        }
//            //        else {
//            //            return "-- NAN --";
//            //        }

//            //    }
//            //}
//        ]
//    }));
//});