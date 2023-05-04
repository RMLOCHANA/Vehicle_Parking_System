function LoadPage(pageNo) {

    var AppendDIV = "divRecords";
    $('#' + AppendDIV).css('visibility', 'hidden');
    $('#divLoad').show();
    $('#spnLoad').show();

    setTimeout(function () {
        $.ajax({

            type: "GET",
            url: PageURL,
            data: GetData(pageNo),
            success: function (result) {
                $('#' + AppendDIV).html(result);
                $('#divLoad').hide();
                $('#spnLoad').hide();
                $('#' + AppendDIV).css('visibility', 'visible');
                ApplyPageSelection(pageNo);
            },
            error: function (result) {
                alert(result.responseText);
            }
        })
    }, 500);
};

function ApplyPageSelection(pageNo) {
    $(".pagination li").each(function (e) {
        $(this).removeClass("active");
    });

    $("#pg_" + pageNo).addClass("active");
}

function PageJump(pageNo) {
    LoadPage(pageNo);
}

function PageNext() {
    var pageNo = Page + 1;
    if ($("#pg_" + pageNo).length > 0) {
        PageJump(pageNo);
    }
}

function PagePrev() {
    var pageNo = Page - 1;
    if ($("#pg_" + pageNo).length > 0) {
        PageJump(pageNo);
    }
}

function ShowAll() {
    var pageNo = 1;
    $("#txtPageSize").val(99999);
    $("#divPagination").hide();
    if ($("#pg_" + pageNo).length > 0) {
        PageJump(pageNo);
    }
}