// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


/* Prevent dropdowns from closing automatically */
$('.dropdown-menu button').click(function (e) {
    e.stopPropagation();
});

/* Tooltips affect performance and are thus opt-in. They are initialized here */
$(function () {
    $('[data-toggle="tooltip"]').tooltip();
});


/* Credit: https://stackoverflow.com/questions/25455567/how-can-i-select-a-paragraph-with-javascript-on-click/25456308#25456308 */
function copyText(id) {
    var range = document.createRange();
    var selection = window.getSelection();
    range.selectNodeContents(document.getElementById(id));
    selection.removeAllRanges();
    selection.addRange(range);
    //copy text to OS clipboard
    document.execCommand('copy');

    //Set listener for tooltip 'shown' event 
    $('#' + id).on('shown.bs.tooltip', function () {
        window.setTimeout(function () {
            $('#' + id).tooltip('hide');
            document.getSelection().removeAllRanges();
        }, 2000);
    });

    //manually trigger tooltip feedback
    $('#' + id).tooltip('show');
}
/* End credit: https://stackoverflow.com/questions/25455567/how-can-i-select-a-paragraph-with-javascript-on-click/25456308#25456308 */


/* toggle sidebar function */
function togglePageMenu() {
    var pageMenu = $('#pageMenu');
    var bodyContent = $('#bodyContent');
    //hide sidebar
    if (pageMenu.is(':visible')) {
        //adjust content padding for larger screens
        if ($('body').outerWidth() >= 700) {
            pageMenu.css('display', 'none');
            bodyContent.css('padding-left', '83px');
            //point arrows right
            $('.leftArrow').css('display', 'none');
            $('.rightArrow').css('display', 'block');
        } else { //small screens
            pageMenu.css('display', '');
            bodyContent.css('padding-left', '');
            //point arrows right
            $('.leftArrow').css('display', '');
            $('.rightArrow').css('display', '');
        }   
    } else { //otherwise        
        //adjust content padding for larger screens
        if ($('body').outerWidth() >= 700) {
            pageMenu.css('display', '');
            bodyContent.css('padding-left', '');
            //point arrows left
            $('.rightArrow').css('display', '');
            $('.leftArrow').css('display', '');
        } else {
            pageMenu.css('display', 'block');
            bodyContent.css('padding-left', '');
            //point arrows left
            $('.rightArrow').css('display', 'none');
            $('.leftArrow').css('display', 'block');
        }
        
    }
}


//highlight page menu options when they come into view 
$(document).ready(function () {
    //store section headings and nav items in arrays for repeated access
    var sections = $('h2 span'),
        navItems = $('#pageMenu nav ol li');

    $(window).on('scroll', function () {
        var cur_pos = $(this).scrollTop();

        sections.each(function () {
            var top = $(this).offset().top,
                id = $(this).attr('id');

            if (cur_pos >= top) {
                navItems.removeClass('active');
                $('#pageMenu nav ol li a[href=\'/#' + id + '\']').parent().addClass('active');
            }
        });
    });
});

/* Begin credit: https://css-tricks.com/snippets/jquery/smooth-scrolling/ */
// Select all links with hashes
$('a[href*="#"]')
    // Remove links that don't actually link to anything
    .not('[href="#"]')
    .not('[href="#0"]')
    .click(function (event) {
        // On-page links
        if (location.pathname.replace(/^\//, '') === this.pathname.replace(/^\//, '')
            &&
            location.hostname === this.hostname) {
            // Figure out element to scroll to
            var target = $(this.hash);
            var id = $(this).attr('href');
            target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
            // Does a scroll target exist?
            if (target.length) {
                $('html, body').animate({
                    scrollTop: target.offset().top
                }, 1000, function () {
                    // Callback after animation
                    // Must change focus!
                    var $target = $(target);
                    $target.focus();
                    if ($target.is(":focus")) { // Checking if the target was focused
                        //Set target item to active
                        $('#pageMenu nav ol li').removeClass('active');
                        $('#pageMenu nav ol li a[href=\'' + id + '\']').parent().addClass('active');
                        return false;
                    } else {
                        $target.attr('tabindex', '-1'); // Adding tabindex for elements not focusable
                        $target.focus(); // Set focus again
                    }
                });
            }
        }
    });
/* End credit: https://css-tricks.com/snippets/jquery/smooth-scrolling/ */


//search site
function siteSearch(searchForm) {
    var domain = "mattmorse.azurewebsites.net/";
    document.getElementById("hiddenquery").value = "site:" + domain + " " + searchForm.queryField.value;
}
