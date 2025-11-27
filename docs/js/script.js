document.addEventListener("DOMContentLoaded", () => {
  const body = document.body;
  const header = document.querySelector(".header");
  const navToggle = document.getElementById("navToggle");
  const navMenu = document.getElementById("navMenu");
  const navLinks = document.querySelectorAll(".nav__link");
  const SCROLL_LIMIT = 10;

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

  // ===== HEADER SCROLL =====
  if (header) {
    window.addEventListener("scroll", () => {
      header.classList.toggle("header--scrolled", window.scrollY > SCROLL_LIMIT);
    });
  }

  // ===== CARROSSEL DA GALERIA (SEÇÃO SOBRE) =====
  const gallery = document.querySelector(".sobre-gallery");

  if (!gallery) return;

  const images = gallery.querySelectorAll(".sobre-gallery__image");
  const dots = gallery.querySelectorAll(".sobre-gallery__dot");
  const prevBtn = gallery.querySelector(".sobre-gallery__control--prev");
  const nextBtn = gallery.querySelector(".sobre-gallery__control--next");
  const viewport = gallery.querySelector(".sobre-gallery__viewport");

  // se faltar alguma peça, nem inicializa
  if (
    !images.length ||
    !dots.length ||
    !prevBtn ||
    !nextBtn ||
    !viewport
  ) {
    return;
  }

  let currentIndex = 0;

  function showSlide(index) {
    // remove estado atual
    images[currentIndex].classList.remove("is-active");
    dots[currentIndex].classList.remove("is-active");

    // calcula novo índice (loop infinito)
    const total = images.length;
    currentIndex = (index + total) % total;

    // ativa novo slide
    images[currentIndex].classList.add("is-active");
    dots[currentIndex].classList.add("is-active");
  }

  // botões anterior/próximo
  prevBtn.addEventListener("click", () => {
    showSlide(currentIndex - 1);
  });

  nextBtn.addEventListener("click", () => {
    showSlide(currentIndex + 1);
  });

  // dots
  dots.forEach((dot) => {
    dot.addEventListener("click", () => {
      const targetIndex = Number(dot.dataset.index);
      showSlide(targetIndex);
    });
  });

  // ===== SWIPE NO CELULAR =====
  let startX = 0;
  let startY = 0;
  let isSwiping = false;

  viewport.addEventListener(
    "touchstart",
    (event) => {
      const touch = event.touches[0];
      startX = touch.clientX;
      startY = touch.clientY;
      isSwiping = true;
    },
    { passive: true }
  );

  viewport.addEventListener(
    "touchend",
    (event) => {
      if (!isSwiping) return;

      const touch = event.changedTouches[0];
      const diffX = touch.clientX - startX;
      const diffY = touch.clientY - startY;

      // garante que é swipe horizontal, não scroll
      if (Math.abs(diffX) > Math.abs(diffY) && Math.abs(diffX) > 40) {
        if (diffX < 0) {
          // arrastou para a esquerda → próxima foto
          showSlide(currentIndex + 1);
        } else {
          // arrastou para a direita → foto anterior
          showSlide(currentIndex - 1);
        }
      }

      isSwiping = false;
    },
    { passive: true }
  );
});