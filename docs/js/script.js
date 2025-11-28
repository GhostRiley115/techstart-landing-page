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
      header.classList.toggle(
        "header--scrolled",
        window.scrollY > SCROLL_LIMIT
      );
    });
  }

  // ===== SCROLL REVEAL – SEÇÃO RECURSOS =====
  const recursosSection = document.querySelector(".section--recursos");
  const recursosCards = document.querySelectorAll(".recurso-card");

  if (recursosSection && recursosCards.length) {
    const prefersReducedMotion = window.matchMedia(
      "(prefers-reduced-motion: reduce)"
    ).matches;

    if (prefersReducedMotion) {
      recursosCards.forEach((card) => card.classList.add("is-visible"));
    } else {
      const observer = new IntersectionObserver(
        (entries, obs) => {
          entries.forEach((entry) => {
            if (entry.isIntersecting) {
              recursosCards.forEach((card, index) => {
                card.style.transitionDelay = `${index * 120}ms`;
                card.classList.add("is-visible");
              });

              obs.unobserve(entry.target);
            }
          });
        },
        {
          threshold: 0.2,
        }
      );

      observer.observe(recursosSection);
    }
  }

  // ===== REVEAL ON SCROLL – COMO FUNCIONA (steps + mockup) =====
  const stepEls = document.querySelectorAll("[data-reveal='step']");

  if (stepEls.length) {
    const prefersReducedMotionSteps = window.matchMedia(
      "(prefers-reduced-motion: reduce)"
    ).matches;

    if (prefersReducedMotionSteps) {
      stepEls.forEach((el) => el.classList.add("is-visible"));
    } else {
      const stepObserver = new IntersectionObserver(
        (entries, obs) => {
          entries.forEach((entry) => {
            if (!entry.isIntersecting) return;

            const el = entry.target;
            const delay = el.dataset.revealDelay || 0;
            el.style.transitionDelay = `${delay}ms`;
            el.classList.add("is-visible");
            obs.unobserve(el);
          });
        },
        {
          threshold: 0.25,
        }
      );

      stepEls.forEach((el) => stepObserver.observe(el));
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
      // ===== CARROSSEL DE DEPOIMENTOS =====
  const testimonials = document.querySelector(".testimonials");

  if (testimonials) {
    const cards = testimonials.querySelectorAll(".testimonial-card");
    const dots = testimonials.querySelectorAll(".testimonials__dot");
    const prevBtn = testimonials.querySelector(".testimonials__control--prev");
    const nextBtn = testimonials.querySelector(".testimonials__control--next");
    const viewport = testimonials.querySelector(".testimonials__viewport");

    // garante que tudo existe antes de iniciar
    if (cards.length && dots.length && prevBtn && nextBtn && viewport) {
      let currentIndex = 0;

      function updateHeight() {
        const activeCard = cards[currentIndex];
        if (!activeCard) return;
        viewport.style.height = activeCard.offsetHeight + "px";
      }

      function showTestimonial(index) {
        // remove estado ativo atual
        cards[currentIndex].classList.remove("is-active");
        dots[currentIndex].classList.remove("is-active");

        const total = cards.length;
        currentIndex = (index + total) % total;

        // ativa o novo
        cards[currentIndex].classList.add("is-active");
        dots[currentIndex].classList.add("is-active");

        updateHeight();
      }

      // inicializa altura com o primeiro card
      window.setTimeout(updateHeight, 0);

      // botões anterior / próximo
      prevBtn.addEventListener("click", () => {
        showTestimonial(currentIndex - 1);
      });

      nextBtn.addEventListener("click", () => {
        showTestimonial(currentIndex + 1);
      });

      // dots
      dots.forEach((dot, index) => {
        dot.addEventListener("click", () => {
          showTestimonial(index);
        });
      });

      // ajusta altura quando a tela muda de tamanho
      window.addEventListener("resize", updateHeight);

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
              // arrastou para a esquerda → próximo depoimento
              showTestimonial(currentIndex + 1);
            } else {
              // arrastou para a direita → depoimento anterior
              showTestimonial(currentIndex - 1);
            }
          }

          isSwiping = false;
        },
        { passive: true }
      );
    }
  }

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

        if (Math.abs(diffX) > Math.abs(diffY) && Math.abs(diffX) > 40) {
          if (diffX < 0) {
            showSlide(currentIndex + 1);
          } else {
            showSlide(currentIndex - 1);
          }
        }

        isSwiping = false;
      },
      { passive: true }
    );
  }
});