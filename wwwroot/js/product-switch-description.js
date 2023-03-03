function productSwitchDescription(that){
  $(that).parent().find('li').each(
    function(){
      $(this).removeClass('active').css('cursor', 'pointer');
    }
  );
  $(that).addClass('active').css('cursor', 'default');

  $(that).parent().parent().find('.description-and-composition').find('.p-tabs__content').each(
    function(){
      if ( $(this).is(":visible") ){
        $(this).hide();
      } else {
        $(this).show();
      }
    }
  )
}