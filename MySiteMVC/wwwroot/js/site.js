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

/* Begin credit: https://css-tricks.com/snippets/jquery/smooth-scrolling/ */
// Select all links with hashes
$('a[href*="#"]')
    // Remove links that don't actually link to anything
    .not('[href="#"]')
    .not('[href="#0"]')
    .not('[href="#myCarousel"]') //added in manually, make more sustainable solution later
    .click(function (event) {
        // On-page links
        if (location.pathname.replace(/^\//, '') === this.pathname.replace(/^\//, '')
            &&
            location.hostname === this.hostname) {
            // Figure out element to scroll to
            var target = $(this.hash);
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
    var menuID = '#pageMenu';
    var bodyContentID = '#bodyContent';
    //if sidebar is shown
    if ($(menuID).is(':visible')) {
        //hide sidebar
        $(menuID).hide('fast', function () {
            //subtract page menu width from left padding of body content
            $(bodyContentID).css('padding-left', parseInt($(bodyContentID).css('padding-left')) - $(menuID).width());
            //point arrows right
            $('.arrow').toggleClass('leftArrow rightArrow');
            //change text to from 'collapse' to 'expand'
            $('.collapseBarText .swappedText').text('expand');
        });
    } else { //otherwise 
        //show sidebar
        $(menuID).show('fast', function () {
            //add sidebar width to page content padding
            $(bodyContentID).css('padding-left', parseInt($(bodyContentID).css('padding-left')) + $(menuID).width());
            //point arrows left
            $('.arrow').toggleClass('leftArrow rightArrow');
            //change text from 'expand' to 'collapse'
            $('.collapseBarText .swappedText').text('collapse');
        });
    }
}

//display post
/*function viewPost(cardLink) {
    //get card element from given link
    var postCard = cardLink.parentElement.parentElement;
    //remove existing expanded post, if any
    var post = document.getElementById('fullPost');
    if (post.hasChildNodes()) {
        post.removeChild(post.childNodes[0]);
        //Restore swapped post's card visibility
        var cards = document.getElementsByClassName('card');
        for (var i = 0; i < cards.length; i++) {
            cards[i].style.display = 'inline-block';
        }
    }
    //use selected post card's id to asynchronously retrieve post content from DB
    //copy card cap, title, summary, dates, and tags from existing card
    //add content to post displaying div
    //append Disqus comment section to post
    //hide selected card
}*/


function viewPost(cardLink) {
    //get card from given link
    var postCard = cardLink.parentElement.parentElement;
    //Remove card from post view, if any
    var post = document.getElementById('fullPost');
    if (post.hasChildNodes()) {
        post.removeChild(post.childNodes[0]);
        //Restore swapped post's card visibility
        var cards = document.getElementsByClassName('card');
        for (var i = 0; i < cards.length; i++)
        {
            cards[i].style.display = 'inline-block';
        }
    }

    //Copy card to post displaying div
    var postCardCopy = postCard.cloneNode(true);
    document.getElementById("fullPost").appendChild(postCardCopy);
    //Hide card 
    postCard.style.display = "none";
}


//search site
function siteSearch(searchForm) {
    var domain = "www.mgordonmorse.com";
    document.getElementById("hiddenquery").value = "site:" + domain + " " + searchForm.queryField.value;
}



/*Credit: Antonis Triantafyllopoulos Src=https://codepen.io/kamenos96/pen/LQMxRe */
(function ($) {
    "use strict";

    // On carousel scroll
    $("#myCarousel").on("slide.bs.carousel", function (e) {
        var $e = $(e.relatedTarget);
        var idx = $e.index();
        var itemsPerSlide = 4;
        var totalItems = $(".carousel-item").length;
        if (idx >= totalItems - (itemsPerSlide - 1)) {
            var it = itemsPerSlide - (totalItems - idx);
            for (var i = 0; i < it; i++) {
                // append slides to end 
                if (e.direction == "left") {
                    $(".carousel-item").eq(i).appendTo(".carousel-inner");
                } else {
                    $(".carousel-item").eq(0).appendTo(".carousel-inner");
                }
            }
        }
    });
})
(jQuery);