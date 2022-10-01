$(() => {
  $('.burger, .overlay').on('click', (e) => {
    e.preventDefault();
    $('.header__inner').toggleClass('header__inner--active');
    $('.overlay').toggleClass('overlay--active');
    $('.burger').toggleClass('burger--active');
  });

  // carousel
  let angle = 0;
  $('.arrow_prev').on('click', (e) => {
    e.preventDefault();
    angle -= 120;
    $('.digital__slider-items').css({ transform: `translateZ(-25rem) rotateY(${angle}deg)` });
  });

  $('.arrow_next').on('click', (e) => {
    e.preventDefault();
    angle += 120;
    $('.digital__slider-items').css({ transform: `translateZ(-25rem) rotateY(${angle}deg)` });
  });
});
