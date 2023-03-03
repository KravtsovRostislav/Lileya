// TOP MENU - CORPORATE SITE

var mainSlideMenu = {
    'burgerBtn': '#lsmenu-corporate .burger',
    'slideMenu': '#lsmenu-corporate .nav-collapse',
    'toggleMenu': function () {

        $(mainSlideMenu.burgerBtn).toggleClass('burger-open');

        if ($(mainSlideMenu.burgerBtn).hasClass('burger-open')) {
            $(mainSlideMenu.slideMenu).addClass('nav-collapse--open');
        } else {
            $(mainSlideMenu.slideMenu).removeClass('nav-collapse--open');
        }
    },
    'hideOnResize': function () {
        if ($(window).width() > 1023) {
            $(mainSlideMenu.burgerBtn).removeClass('burger-open');
            $(mainSlideMenu.slideMenu).removeClass('nav-collapse--open');
        }
    }
};

$(window).resize(mainSlideMenu.hideOnResize);

$(document)
    .on('click', mainSlideMenu.burgerBtn, mainSlideMenu.toggleMenu)
    .ready(function () {
        $('#ls-carousel').owlCarousel({
            items: 1,
            loop: true,
            autoplay: true,
            autoplayTimeout: 10000,
            autoplayHoverPause: false,
            nav: false,
            dots: true,
            smartSpeed: 500,
            animateOut: 'fadeOut',
            animateIn: 'fadeIn',
            responsiveRefreshRate : 100
        });
    });


// SHOP MENU CONSTRUCTOR & METHODS

function Shopmenu() {

}

Shopmenu.prototype.toggleMenu = function(target) {

    if(target.classList.contains('burger-active')) {
        target.classList.remove('burger-active');
        shopSlideMenu.classList.remove('group-collapse--open');
    } else {
        target.classList.add('burger-active');
        shopSlideMenu.classList.add('group-collapse--open');
    }
};

Shopmenu.prototype.hideOnResize = function() {
    if(window.innerWidth > 1023) {
        burgerBtn.classList.remove('burger-active');
        shopSlideMenu.classList.remove('group-collapse--open');
    }
};

Shopmenu.prototype.subMenuToggle = function(target) {
    const element = target.closest('li');

    if(element.classList.contains('open')) {
        element.classList.remove('open');

    } else {
        subMenuLi.forEach( function(el){
            el.closest('li').classList.remove('open');
            //el.closest('li').nextElementSibling.classList.remove('open');
        });
        element.classList.add('open');
    }
};

Shopmenu.prototype.hideOnClickOutside = function(elClicked) {
    if(elClicked.closest('.js-shopmenu__dropdown') === null) {
        subMenuLi.forEach(function(el) {
            el.classList.remove('open');
        });
    }
};


// SHOP MENU UI ELEMENTS

const burgerBtn = document.querySelector('#shopmenu .burger');
const shopSlideMenu = document.querySelector('#shopmenu .group-collapse');
const subMenuLi = document.querySelectorAll('.js-shopmenu__dropdown');
const subMenu = document.querySelectorAll('.js-shopmenu__dropdown > a');

// SHOP MENU EVENT LISTENERS

if(burgerBtn != null) {
    burgerBtn.addEventListener('click', function() {
        const shopmenu = new Shopmenu();
        shopmenu.toggleMenu(burgerBtn);
    });
}


subMenu.forEach(function(el) {
    el.addEventListener('click', function(e){
        const shopmenu = new Shopmenu();
        shopmenu.subMenuToggle(e.target);
    });
});

if(burgerBtn != null) {
    window.addEventListener('resize', function () {
        const shopmenu = new Shopmenu();
        shopmenu.hideOnResize();
    });
}

window.addEventListener('click', function(e) {
    e.stopPropagation();
    const elClicked = e.target;

    const shopmenu = new Shopmenu();
    shopmenu.hideOnClickOutside(elClicked);
});

// SEARCH TOGGLE

function SearchBar () {
    this.searchContainer = document.querySelector('.js-topblock-container');
    this.searchOpen = document.querySelector('.js-topblock-search');
    this.searchClose = document.querySelector('.js-search-close');
};

function SearchBarUI (){};

SearchBarUI.prototype.searchOpen = function(el) {
    if(el.searchOpen === null) {
        return;
    }
    el.searchOpen.addEventListener('click', function(e){
        e.stopPropagation();
        el.searchContainer.classList.add('open');
        console.log('click');
    })
};

SearchBarUI.prototype.searchClose = function(el) {
    if(el.searchClose === null) {
        return;
    }
    el.searchClose.addEventListener('click', function(e){
        e.stopPropagation();
        el.searchContainer.classList.remove('open');

    })
};

const searchBlock = new SearchBar();
const search = new SearchBarUI();
search.searchOpen(searchBlock);
search.searchClose(searchBlock);



// SHOP MAP HANDLING

function showMap () {
    const shopsBtnList = document.querySelectorAll('div.btn-map');

    shopsBtnList.forEach(function (e) {
        e.addEventListener('click', function () {
            this.classList.toggle('btn-map--show');
            this.previousElementSibling.classList.toggle('shop-map--show');
        });
    });
}


// FOOTER HANDLING
const footerNav = document.querySelectorAll('.footer-navblock__header');

footerNav.forEach(function (e) {
    e.addEventListener('click', function () {
        this.classList.toggle('open');
        this.nextElementSibling.classList.toggle('open');
    })
});

window.addEventListener('resize', function () {
    if (window.innerWidth > 992) {
        footerNav.forEach(function (e) {
            e.classList.remove('open');
            e.nextElementSibling.classList.remove('open');
        });
    }
});

// Filter bar settings and actions

var filterBar = {
    'filterToggle': '#js-filterbar-toggle',
    'filterClose': '#js-filterbar-close',
    'filterBar': '#js-filterbar',
    'resetBtn': '#filters-reset',
    'checkboxes': '#js-filterbar input:checkbox',
    'toggleFilter': function () {
        $(filterBar.filterBar).toggleClass('filterbar--open');
    },
    'closeFilter': function() {
        $(filterBar.filterBar).removeClass('filterbar--open');
    },
    'resetFilters': function() {
        $(filterBar.checkboxes).each(function(){
            this.checked = false;
        });
        $(filterBar.resetBtn).closest('.filters-selected').css({'display':'none'});
    }
};

$(document)
    .on('click', filterBar.filterToggle, filterBar.toggleFilter)
    .on('click', filterBar.filterClose, filterBar.closeFilter)
    .on('click', filterBar.resetBtn, filterBar.resetFilters);



// $(function(){
//
//     $('.p-tabs__caption').on('click', 'li:not(.active)', function() {
//     $(this)
//       .addClass('active').siblings().removeClass('active')
//       .closest('.p-tabs').find('.p-tabs__data .p-tabs__content').removeClass('active').eq($(this).index()).addClass('active');
//     });
//
// });


// var workshopModal = new Vue({
//     el: '#workshop-list',
//     data: {
//         modalId: ''
//     },
//     methods: {
//         test: function (event) {
//             this.modalId = event.target.getAttribute('data-modal');
//             console.log(this.modalId);
//         }
//     }
// });

// Vue.component('modal', {
//     template: '#modal-template'
// });
//
// var workshopAction = new Vue ({
//     el: '#workshop-action',
//     data: {
//         showModal: false,
//         workshopBuy: false,
//         workshopCall: false
//     },
//     methods: {
//         onClick: function(event){
//             const value = event.target.getAttribute('data-action');
//             value === 'participate' ? this.workshopBuy = true : this.workshopBuy = false;
//             this.showModal = true;
//         }
//     }
// });

// var shopMenuVue = new Vue ({
//     el: '#shopmenu',
//     data: {
//         burgerActive: false,
//         dropdownActive: false
//     },
//     mounted: function () {
//         window.addEventListener('resize', this.hideOnResize)
//     },
//     //beforeDestroy: function () {
//     //    window.removeEventListener('resize', this.hideOnResize)
//     //},
//     methods: {
//         burgerHandle: function() {
//             this.burgerActive = !this.burgerActive;
//             //console.log('clicked');
//         },
//         hideOnResize: function() {
//             if(window.innerWidth > 1023) {
//                 this.burgerActive = false;
//             }
//         }
//     }
// });

