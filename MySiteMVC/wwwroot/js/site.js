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
    var bodyContentID = '#bodyContent';
    //if sidebar is shown
    if (pageMenu.is(':visible')) {
        //hide sidebar
        pageMenu.hide();
        //small screens
        if ($('body').width() < 700) {
            console.log('small screen');
            //pageMenu.css('box-shadow', 'initial');
        } else { //larger screens
            console.log('large screen');
            //subtract page menu width from left padding of body content
            $(bodyContentID).css('padding-left', parseInt($(bodyContentID).css('padding-left')) - pageMenu.width());
        }
        //point arrows right
        $('.leftArrow').css('display', 'none');
        $('.rightArrow').css('display', 'block');
        //change text to from 'collapse' to 'expand'
        $('.collapseBarText .swappedText').text('expand');
    } else { //otherwise 
        //show sidebar
        pageMenu.show();
        //small screens
        if ($('body').width() < 700) {
            console.log('small screen');
        } else { //larger screens
            console.log('large screen');
            //add sidebar width to page content padding
            $(bodyContentID).css('padding-left', parseInt($(bodyContentID).css('padding-left')) + pageMenu.width());
        }
        //point arrows left
        $('.rightArrow').css('display', 'none');
        $('.leftArrow').css('display', 'block');
        
        //change text from 'expand' to 'collapse'
        $('.collapseBarText .swappedText').text('collapse');
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
    var domain = "https://mattmorse.azurewebsites.net/";
    document.getElementById("hiddenquery").value = "site:" + domain + " " + searchForm.queryField.value;
}
