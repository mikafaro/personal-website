

window.toggleTheme = (isDark) => {
    localStorage.theme = isDark ? "dark" : "light";
    setTheme();
}

window.getIsDark = () => {
    return (
        localStorage.theme === 'dark' ||
        (!localStorage.theme && window.matchMedia('(prefers-color-scheme: dark)').matches)
    );
}