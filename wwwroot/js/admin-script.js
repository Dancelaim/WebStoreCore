// JS Admib
$(ActiveTabSet())
function ActiveTabSet() {
    var activeTabId = sessionStorage.getItem("ActiveTabId");
    if (activeTabId == null) {
        $(".opt-head:first").addClass("active-tab-head");
        $(".opt-body:first").addClass("active-tab-body");
    } else {
        $("#" + activeTabId).addClass("active-tab-head");
        $("." + activeTabId).addClass("active-tab-body");
        sessionStorage.removeItem("ActiveTabId");
    }
}
//Product tabs
$(document).on("click", ".tab-title", function () {
   
        var TabName = $(this).attr("id");
    switch (TabName) {
        case "tab1":
            $(".tab2, .tab3").removeClass("active-tab");
            $("#tab2, #tab3").removeClass("active-title");
            $(".tab1").addClass("active-tab");
            $("#tab1").addClass("active-title");
            break;
        case "tab2":
            $(".tab1, .tab3").removeClass("active-tab");
            $("#tab1, #tab3").removeClass("active-title");
            $(".tab2").addClass("active-tab");
            $("#tab2").addClass("active-title");
            break;
        case "tab3":
            $(".tab2, .tab1").removeClass("active-tab");
            $("#tab2, #tab1").removeClass("active-title");
            $(".tab3").addClass("active-tab");
            $("#tab3").addClass("active-title");
            break;
    }
})
//Option tabs
$(document).on("click", ".opt-head",function () {
    if (this.parentNode) {
        var TabName = $(this).attr("id");
        $(".opt-head").removeClass("active-tab-head");
        $(".opt-body").removeClass("active-tab-body");

        $(this).addClass("active-tab-head");
        $(".options-tabs").find("." + TabName).addClass("active-tab-body")
    }
});
//populate Parent Option selectList
function PopulateParentOption() {
    var dropDowns = document.querySelectorAll(".ddParent")
    dropDowns.forEach(function (Item) {
        var selectedOption = Item.querySelector('select').value
        Item.querySelector('select').length = 0
        var parents = document.querySelectorAll('.OptionName input')

        parents.forEach(function (parent) {
            var values = Item.querySelector('select').options
            var isExists = false
            var EmptyExists = false
            for (value of values)
            {
                if (value.innerText == parent.value) {
                    isExists = true
                }
                if (value.innerText == "Empty") {
                    EmptyExists = true
                }
            }
            var curOptVal = $(Item).closest('.opt-body').find('.OptionName input').val()
            if (!isExists && parent.value != curOptVal) {
                if (!EmptyExists && selectedOption == '') {
                    Item.querySelector('select').appendChild(new Option("Empty", "Empty",true))
                } else if (!EmptyExists) {
                    Item.querySelector('select').appendChild(new Option("Empty", "Empty"))
                }

                if (selectedOption == parent.value) {
                    Item.querySelector('select').appendChild(new Option(parent.value, parent.value, true))
                    Item.querySelector('select').value = parent.value
                } else {
                    Item.querySelector('select').appendChild(new Option(parent.value))
                }
            }
        });
    });
    $('.ddParent select').selectpicker('refresh');
}
//AddEmpty value to selectors
function AddEmptyValues() {

    var selects = document.querySelectorAll('select')
    selects.forEach(function (select) {
        select.appendChild(new Option("Empty", "Empty", true))
        select.selectpicker('refresh');
    });
}
//Populate Parameter parents with ajax
$(document).on("change", '.ddParent .bootstrap-select select',function ()  {

        var dropDowns = this.closest('.opt-body').getElementsByClassName('pddParent')

        for (var i of dropDowns) {
            i.querySelector('select').length = 0
            var parentOptionName = this.value.replace(/[)(]/g, '').replace(/\s/g, '_')
            if (parentOptionName == "") {
                $('.pddParent select').selectpicker('refresh');
            } else {
                var parentOption = document.getElementsByClassName(parentOptionName);
                var paramParents = parentOption[0].querySelectorAll('.Param_name')

                paramParents.forEach(function (parent) {
                    i.querySelector('select').appendChild(new Option(parent.value))
                });
            }
        }

        $('.pddParent select').selectpicker('refresh');
})
//Remove SiteBlock from list
$(document).on("click", '.rmvbtn', function () {
    var confirm = window.confirm("Are you sure you want to delete " + $(this).closest('tr').find('td:first').text() + " Entity?");
    if (confirm) {
        $.ajax({
            cache: false,
            type: 'POST',
            url: '/admin/Remove',
            data: {
                Id: $(this).closest('.text-center').find("#SiteBlockId").val(),
                type: $("#HtmlBlocks").val()
            },
            success: function (data) {
                window.location.reload();
            }
        });
    }
})
//Save product and redirect to Options
$(document).on("click", "#goToProdOptions", function () {
    $(this).closest("form").attr("action", "/admin/SaveProduct?navigateToProdOpt=true");
})
//Add Option
$(document).on("click", ".option-add", function () {
    $.ajax({
        cache: false,
        type: 'POST',
        url: '/admin/AddOption',
        data: {
            optionName: $("#Template_Options").val(),
            prodId: $("#ProductId").val()
        },
        success: function (data) {
            $(".options-tabs").append(data);
            PopulateParentOption();
            DisableOptions();
        },
        error: function (ex) {
            alert('Failed to add option.' + ex);
        }
    });
})
//Add SiteBlock children
$(document).on("click", ".siteblock-add", function () {
    $.ajax({
        cache: false,
        type: 'POST',
        url: '/admin/AddSiteBlock',
        success: function (data) {
            $('.childblock-list').append(data)
            TaToHtmlEditor()
            //window.location.href = window.location.href.replace("?type=HtmlBlocks", "?Id=" + data + "&type=HtmlBlocks");
        },
        error: function (ex) {
            alert('Failed to add SiteBlock.' + ex);
        }
    });
})
//Remove SiteBlock children
$(document).on("click", ".remove-htmlbox", function () {
    $(this).closest(".param-fields").remove();
});
//Remove Option
$(document).on("click", ".remove-option", function () {
    var confirm = window.confirm("Are you sure you want to delete" + " " + $(this).closest('.opt-head').text() + " option");
    if (confirm == true) {
        var elem = document.getElementsByClassName($(this).closest('.opt-head').attr("id"))[0]
        elem.parentElement.removeChild(elem)
            elem = document.getElementById($(this).closest('.opt-head').attr("id"))
        elem.parentElement.removeChild(elem).after(ActiveTabSet())
    } 
    DisableOptions()
    PopulateParentOption()
})
//Remove Parameter
$(document).on("click", ".remove-param", function () {
    var confirm = window.confirm("Are you sure you want to delete" + " " + $(this).closest('.param-fields').find('.Param_name').val() + " parameter");
    if (confirm == true) {
        $.ajax({
            cache: false,
            type: 'POST',
            url: '/admin/RemoveParam',
            data: {
                optionId: $(this).closest('.opt-body.active-tab-body').find("input:first").val(),
                paramId: $(this).closest('.param-fields').find("input").val()
            },
            success: function (data) {
                sessionStorage.setItem("ActiveTabId", $(".active-tab-head").attr("id"));
                window.location.reload();
            },
            error: function (ex) {
                alert('Failed to remove param.' + ex);
            }
        });
    }
})
//Add Parameter
$(document).on("click", ".param-add", function () {
        $.ajax({
            cache: false,
            type: 'POST',
            url: "/admin/AddParam",
            data: {
                optionName: $(this).closest('.opt-body').find('.OptionName').find("input").val(),
                paramName: $(this).closest(".add-param-block").find("select").val()
            },
            success: function (data) {
                $('.param-list').append(data)
            },
            error: function (ex) {
                alert('Failed to add Parameter.' + ex);
            }
        });
})
//Activate LiveSearch for dropdowns
$(function () {
    $('select').selectpicker({
        liveSearch: true
    });
});
//left menu collapsed script
$(document).on("click", ".left-column .title span.nav-ico", function () {
    if ($(".left-column").hasClass("collapsed")) {
        $(".left-column").removeClass("collapsed");
        $(".content").removeClass("content-collapsed");
    } else {
        $(".left-column").addClass("collapsed");
        $(".content").addClass("content-collapsed");
    }
})
$(document).on("click", ".left-column ul .dropdown", function () {
    $(this).find(".dropdown-menu").toggle();
})
//Upload product image to Controller
//$(document).ready(function () {
//    var imgThumbPath = $("#ProductImageThumb").val();
//    var imgPath = $("#ProductImage").val();
//    $(".imgThumb").attr("src", imgThumbPath);
//    $(".imgLarge").attr("src", imgPath);
//})
//Image Upload for product
$(".ImageUpload").change(function () {
    var formData = new FormData();
    var file = document.getElementById($(this).attr("id")).files[0];

    formData.append("File", file);

    var curEl = $(this);

    var path = "/Images/Product/" + $("#SelectedGame").val().toLowerCase() + "/" + $("#SelectedCategory").val().toLowerCase();
    formData.append("Path", path);

    formData.append("RequiredFileName", $("#ProductName").val().toLowerCase().replace(/[.*+?^${}()|/[\]\\]/g, '_') + ($(this).attr("id") == "Thumbfile" ? "" : "_large"));


    $.ajax({
        cache: false,
        type: 'POST',
        url: '/admin/Upload',
        data: formData,
        processData: false,
        contentType: false,
        success: function (data) {
            if (data != "") {
                curEl.closest('.imageBlock').find('input').last().val(data)
                curEl.closest('.imageBlock').find('img').attr("src", data);
            }
            $(".imgThumb").attr("src", $("#ProductImageThumb").val() + "?t=" + new Date().getTime());
            $(".imgLarge").attr("src", $("#ProductImage").val() + "?t=" + new Date().getTime());
        }
    });
});
//Image Upload for Article
$(".ArticleImageUpload").change(function () {
    var formData = new FormData();
    var file = document.getElementById($(this).attr("id")).files[0];

    formData.append("File", file);

    var curEl = $(this);

    var path = "/Images/Article/" + $("#SelectedGame").val().toLowerCase();
    formData.append("Path", path);

    formData.append("RequiredFileName", $("#Title").val().toLowerCase().replace(/[.*+?^${}()|/[\]\\]/g, '_'));

    $.ajax({
        cache: false,
        type: 'POST',
        url: '/admin/Upload',
        data: formData,
        processData: false,
        contentType: false,
        success: function (data) {
            if (data != "") { 
                curEl.closest('.imageBlock').find('input').last().val(data)
                curEl.closest('.imageBlock').find('img').attr("src", data);
            }
        }
        //$(".ArticleImagePath").attr("src", $("#ImagePath").val() + "?t=" + new Date().getTime());   
    });
});
$(".HtmlBlockChildrenImageUpload").change(function () {
    var formData = new FormData();
    var file = document.getElementById($(this).attr("id")).files[0];

    formData.append("File", file);

    var curEl = $(this);
    var path = "/Images/HtmlBLock/" + $("#ParentTitle").val().toLowerCase();
    formData.append("Path", path);

    formData.append("RequiredFileName", this.closest('.param-fields').querySelector('.ChildTitle').value.toLowerCase().replace(/[.*+?^${}()|/[\]\\]/g, '_'));

    $.ajax({
        cache: false,
        type: 'POST',
        url: '/admin/Upload',
        data: formData,
        processData: false,
        contentType: false,
        success: function (data) {
            if (data != "") {
                curEl.closest('.imageBlock').find('input').last().val(data)
                curEl.closest('.imageBlock').find('img').attr("src", data);
            }
        }
    });
});

//TextArea to HtmlEditor
$(TaToHtmlEditor());
function TaToHtmlEditor(){
    var textAreas = document.getElementsByTagName('textarea');
    for (let i = 0; i <= textAreas.length - 1; i++) {
        
        CKEDITOR.replace(textAreas[i].id);
    }
};
//block added options
$(DisableOptions());
function DisableOptions(){
    var optionslist = document.getElementById("Template_Options").options;
    for (var optl of optionslist) {
        optl.disabled = false;
    }
    var existingsOptions = document.querySelectorAll('.OptionName input');
    // disabledOptionsList = $('.opt-body').find('.text-box:first');
    existingsOptions.forEach(function (opt) {
        for (var optl of optionslist){
            if (optl.value == opt.value) {
                optl.disabled = true;
            }
        }
    })
    $('#Template_Options').selectpicker('refresh');
};