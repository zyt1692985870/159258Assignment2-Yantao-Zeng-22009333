document.addEventListener('DOMContentLoaded', function () {
  const numSlides = 5; // 设置图片的总数
  let currentIndex = 0;

  // 自动轮播函数
  function autoSlide() {
    currentIndex = (currentIndex + 1) % numSlides;
    updateSlide();
  }

  // 更新当前显示的图片
  function updateSlide() {
    const imgContainer = document.querySelector('.banner-img-container');
    const slideWidth = 100 / numSlides;
    imgContainer.style.transform = `translateX(-${currentIndex * slideWidth}%)`;
  }

  // 向前切换图片
  function prevSlide() {
    currentIndex = (currentIndex - 1 + numSlides) % numSlides;
    updateSlide();
  }

  // 向后切换图片
  function nextSlide() {
    currentIndex = (currentIndex + 1) % numSlides;
    updateSlide();
  }

  // 每隔5秒自动切换图片
  setInterval(autoSlide, 5000);

  // 点击左箭头切换到上一张图片
  const prevButton = document.querySelector('.banner-control-prev');
  prevButton.addEventListener('click', prevSlide);

  // 点击右箭头切换到下一张图片
  const nextButton = document.querySelector('.banner-control-next');
  nextButton.addEventListener('click', nextSlide);
});
