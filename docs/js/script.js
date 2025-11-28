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
        // ===== CARROSSEL DEPOIMENTOS =====
    const testimonialsSection = document.querySelector(".section--testimonials");

    if (testimonialsSection) {
      const viewport = testimonialsSection.querySelector(".testimonials__viewport");
      const cards = viewport.querySelectorAll(".testimonial-card");
      const dots = testimonialsSection.querySelectorAll(".testimonials__dot");
      const prevBtn = testimonialsSection.querySelector(".testimonials__control--prev");
      const nextBtn = testimonialsSection.querySelector(".testimonials__control--next");

      if (cards.length && dots.length && viewport) {
        let currentIndex = 0;
        let autoPlayId = null;
        const AUTO_PLAY_DELAY = 9000; // 9s pra dar tempo de ler

        function updateViewportHeight() {
          const activeCard = cards[currentIndex];
          if (!activeCard) return;

          // pega a altura real do card (já com texto quebrado no tamanho atual da tela)
          const cardHeight = activeCard.offsetHeight;
          viewport.style.height = cardHeight + "px";
        }

        function setActiveSlide(index) {
          cards[currentIndex].classList.remove("is-active");
          dots[currentIndex].classList.remove("is-active");

          const total = cards.length;
          currentIndex = (index + total) % total;

          cards[currentIndex].classList.add("is-active");
          dots[currentIndex].classList.add("is-active");

          updateViewportHeight();
        }

        function goToNext() {
          setActiveSlide(currentIndex + 1);
        }

        function goToPrev() {
          setActiveSlide(currentIndex - 1);
        }

        function restartAutoPlay() {
          if (autoPlayId) clearInterval(autoPlayId);
          autoPlayId = setInterval(goToNext, AUTO_PLAY_DELAY);
        }

        // eventos das setas
        if (prevBtn) {
          prevBtn.addEventListener("click", () => {
            goToPrev();
            restartAutoPlay();
          });
        }

        if (nextBtn) {
          nextBtn.addEventListener("click", () => {
            goToNext();
            restartAutoPlay();
          });
        }

        // eventos dos dots
        dots.forEach((dot) => {
          dot.addEventListener("click", () => {
            const targetIndex = Number(dot.dataset.index);
            setActiveSlide(targetIndex);
            restartAutoPlay();
          });
        });

        // inicializa
        // garante que só o primeiro está ativo
        cards.forEach((card, idx) => {
          if (idx === 0) {
            card.classList.add("is-active");
            dots[idx].classList.add("is-active");
          } else {
            card.classList.remove("is-active");
            dots[idx].classList.remove("is-active");
          }
        });

        // calcula a altura depois que o layout estiver pronto
        window.setTimeout(updateViewportHeight, 0);

        // recalcula sempre que a tela mudar de tamanho (mobile, rotação, etc.)
        window.addEventListener("resize", () => {
          // pequeno delay pra deixar o navegador terminar de quebrar o texto
          window.setTimeout(updateViewportHeight, 100);
        });

        // autoplay
        restartAutoPlay();
      }
    }
  }
});