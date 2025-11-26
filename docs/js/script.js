document.addEventListener("DOMContentLoaded", () => {
  const body = document.body;
  const header = document.querySelector(".header");
  const navToggle = document.getElementById("navToggle");
  const navMenu = document.getElementById("navMenu");
  const navLinks = document.querySelectorAll(".nav__link");

  // Abrir/fechar menu mobile
  navToggle.addEventListener("click", () => {
    const isOpen = body.classList.toggle("nav-open");
    navToggle.setAttribute("aria-expanded", isOpen ? "true" : "false");
  });

  // Fechar menu ao clicar em um link
  navLinks.forEach((link) => {
    link.addEventListener("click", () => {
      body.classList.remove("nav-open");
      navToggle.setAttribute("aria-expanded", "false");
    });
  });

  // Mudar estilo do header ao rolar
  const SCROLL_LIMIT = 10;

  window.addEventListener("scroll", () => {
    if (window.scrollY > SCROLL_LIMIT) {
      header.classList.add("header--scrolled");
    } else {
      header.classList.remove("header--scrolled");
    }
  });
});