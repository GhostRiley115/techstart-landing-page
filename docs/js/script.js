document.addEventListener("DOMContentLoaded", () => {
  const body = document.body;
  const header = document.querySelector(".header");
  const navToggle = document.getElementById("navToggle");
  const navMenu = document.getElementById("navMenu"); // ✅ agora declarado
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

  // ===== TROCA DE IDIOMA (PT / EN) =====
  const langButtons = document.querySelectorAll(".nav__lang-btn[data-lang]");
  const translatableEls = document.querySelectorAll("[data-i18n-en]");

  // guarda o conteúdo original (PT) com HTML
  translatableEls.forEach((el) => {
    if (!el.dataset.i18nPt) {
      el.dataset.i18nPt = el.innerHTML.trim();
    }
  });

  function setLanguage(lang) {
    const isEnglish = lang === "en";

    // atributo lang da página (acessibilidade / SEO)
    document.documentElement.lang = isEnglish ? "en" : "pt-BR";

    // estado visual dos botões PT / EN
    langButtons.forEach((btn) => {
      btn.classList.toggle(
        "nav__lang-btn--active",
        btn.dataset.lang === lang
      );
    });

    // troca o texto
    translatableEls.forEach((el) => {
      const ptText = el.dataset.i18nPt;
      const enText = el.dataset.i18nEn;

      if (isEnglish && enText) {
        el.innerHTML = enText; // permite <br> nos títulos
      } else if (ptText) {
        el.innerHTML = ptText;
      }
    });
  }

  // clique nos botões PT / EN
  langButtons.forEach((btn) => {
    btn.addEventListener("click", () => {
      const lang = btn.dataset.lang === "en" ? "en" : "pt";
      setLanguage(lang);
    });
  });

  // idioma inicial: PT
  setLanguage("pt");

  // ===== HEADER SCROLL (muda fundo da navbar ao rolar) =====
  if (header) {
    window.addEventListener("scroll", () => {
      header.classList.toggle(
        "header--scrolled",
        window.scrollY > SCROLL_LIMIT
      );
    });
  }

  // ===== BOTÃO VOLTAR AO TOPO =====
  const scrollTopBtn = document.querySelector(".scroll-top");

  if (scrollTopBtn) {
    window.addEventListener("scroll", () => {
      if (window.scrollY > 400) {
        scrollTopBtn.classList.add("is-visible");
      } else {
        scrollTopBtn.classList.remove("is-visible");
      }
    });

    scrollTopBtn.addEventListener("click", () => {
      window.scrollTo({ top: 0, behavior: "smooth" });
    });
  }

  // ===== REVEAL ON SCROLL – BLOCO GENÉRICO (steps, equipe, etc.) =====
  const revealEls = document.querySelectorAll("[data-reveal]");

  if (revealEls.length) {
    const prefersReducedMotionReveal = window.matchMedia(
      "(prefers-reduced-motion: reduce)"
    ).matches;

    if (prefersReducedMotionReveal) {
      revealEls.forEach((el) => el.classList.add("is-visible"));
    } else {
      const revealObserver = new IntersectionObserver(
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

      revealEls.forEach((el) => revealObserver.observe(el));
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

    if (images.length && dots.length && prevBtn && nextBtn && viewport) {
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
  }

  // ===== CARROSSEL DEPOIMENTOS =====
  const testimonialsSection = document.querySelector(".section--testimonials");

  if (testimonialsSection) {
    const viewport = testimonialsSection.querySelector(".testimonials__viewport");
    if (!viewport) return;

    const cards = viewport.querySelectorAll(".testimonial-card");
    const dots = testimonialsSection.querySelectorAll(".testimonials__dot");
    const prevBtn = testimonialsSection.querySelector(
      ".testimonials__control--prev"
    );
    const nextBtn = testimonialsSection.querySelector(
      ".testimonials__control--next"
    );

    if (cards.length && dots.length) {
      let currentIndex = 0;
      let autoplayId = null;
      const AUTO_PLAY_DELAY = 9000;

      function setActiveSlide(index) {
        cards[currentIndex].classList.remove("is-active");
        dots[currentIndex].classList.remove("is-active");

        const total = cards.length;
        currentIndex = (index + total) % total;

        cards[currentIndex].classList.add("is-active");
        dots[currentIndex].classList.add("is-active");
      }

      function goToNext() {
        setActiveSlide(currentIndex + 1);
      }

      function goToPrev() {
        setActiveSlide(currentIndex - 1);
      }

      function restartAutoPlay() {
        if (autoplayId) clearInterval(autoplayId);
        autoplayId = setInterval(goToNext, AUTO_PLAY_DELAY);
      }

      // inicializa
      cards.forEach((card, idx) => {
        card.classList.toggle("is-active", idx === 0);
        if (dots[idx]) {
          dots[idx].classList.toggle("is-active", idx === 0);
        }
      });

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

      dots.forEach((dot) => {
        dot.addEventListener("click", () => {
          const targetIndex = Number(dot.dataset.index);
          setActiveSlide(targetIndex);
          restartAutoPlay();
        });
      });

      restartAutoPlay();
    }
  }
});