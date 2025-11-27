document.addEventListener("DOMContentLoaded", () => {
  const body = document.body;
  const header = document.querySelector(".header");
  const navToggle = document.getElementById("navToggle");
  const navMenu = document.getElementById("navMenu");
  const navLinks = document.querySelectorAll(".nav__link");

  // ===== NAVBAR MOBILE =====

  if (navToggle && navMenu) {
    navToggle.addEventListener("click", () => {
      const isOpen = body.classList.toggle("nav-open");
      navToggle.setAttribute("aria-expanded", isOpen ? "true" : "false");
    });

    navLinks.forEach((link) => {
      link.addEventListener("click", () => {
        body.classList.remove("nav-open");
        navToggle.setAttribute("aria-expanded", "false");
      });
    });
  }

  const SCROLL_LIMIT = 10;

  window.addEventListener("scroll", () => {
    if (window.scrollY > SCROLL_LIMIT) {
      header.classList.add("header--scrolled");
    } else {
      header.classList.remove("header--scrolled");
    }
  });

  // ===== CARROSSEL DA GALERIA (SEÇÃO SOBRE) =====
  const gallery = document.querySelector(".sobre-gallery");

  if (gallery) {
    const images = gallery.querySelectorAll(".sobre-gallery__image");
    const dots = gallery.querySelectorAll(".sobre-gallery__dot");
    const prevBtn = gallery.querySelector(".sobre-gallery__control--prev");
    const nextBtn = gallery.querySelector(".sobre-gallery__control--next");

    if (!images.length || !dots.length || !prevBtn || !nextBtn) {
      return;
    }

    let currentIndex = 0;

    function showSlide(index) {
      const total = images.length;

      images[currentIndex].classList.remove("is-active");
      dots[currentIndex].classList.remove("is-active");

      currentIndex = (index + total) % total;

      images[currentIndex].classList.add("is-active");
      dots[currentIndex].classList.add("is-active");
    }

    prevBtn.addEventListener("click", () => {
      showSlide(currentIndex - 1);
    });

    nextBtn.addEventListener("click", () => {
      showSlide(currentIndex + 1);
    });

    dots.forEach((dot) => {
      dot.addEventListener("click", () => {
        const targetIndex = Number(dot.dataset.index);
        showSlide(targetIndex);
      });
    });
  }
});