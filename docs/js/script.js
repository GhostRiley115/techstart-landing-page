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

  // ===== SCROLL REVEAL – SEÇÃO RECURSOS =====
  const recursosSection = document.querySelector(".section--recursos");
  const recursosCards = document.querySelectorAll(".recurso-card");

  if (recursosSection && recursosCards.length) {
    const prefersReducedMotion = window.matchMedia(
      "(prefers-reduced-motion: reduce)"
    ).matches;

    // Acessibilidade: se o usuário prefere menos animação, já mostra tudo direto
    if (prefersReducedMotion) {
      recursosCards.forEach((card) => card.classList.add("is-visible"));
    } else {
      const observer = new IntersectionObserver(
        (entries, obs) => {
          entries.forEach((entry) => {
            if (entry.isIntersecting) {
              recursosCards.forEach((card, index) => {
                // atraso em cascata (stagger) – 0ms, 120ms, 240ms...
                card.style.transitionDelay = `${index * 120}ms`;
                card.classList.add("is-visible");
              });

              // não precisa observar mais depois que mostrou
              obs.unobserve(entry.target);
            }
          });
        },
        {
          threshold: 0.2, // quando ~20% da seção aparecer na tela
        }
      );

      observer.observe(recursosSection);
    }
  }

  // ===== CARROSSEL DA GALERIA (SEÇÃO SOBRE) =====
  const gallery = document.querySelector(".sobre-gallery");

  if (gallery) {
    const images = gallery.querySelectorAll(".sobre-gallery__image");
    const dots = gallery.querySelectorAll(".sobre-gallery__dot");
    const prevBtn = gallery.querySelector(".sobre-gallery__control--prev");
    const nextBtn = gallery.querySelector(".sobre-gallery__control--next");
    const viewport = gallery.querySelector(".sobre-gallery__viewport");

    // se faltar alguma parte, nem inicializa
    if (!images.length || !dots.length || !prevBtn || !nextBtn || !viewport) {
      return;
    }

    let currentIndex = 0;

    function showSlide(index) {
      images[currentIndex].classList.remove("is-active");
      dots[currentIndex].classList.remove("is-active");

      const total = images.length;
      currentIndex = (index + total) % total;

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

        // garante que é swipe horizontal, não scroll vertical
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
  }
});