document.addEventListener("DOMContentLoaded", () => {
    const buttons = {
        open: document.querySelector('.add-button'),
        create: document.querySelector('#saveBtn'),
        delete: document.querySelector('.deleteItem-button')
    };

    const soundPaths = {
        open: '../sounds/openModal.mp3',
        create: '../sounds/newItem.mp3',
        delete: '../sounds/deleteItem.mp3'
    };

    const sounds = {};
    for (const key in soundPaths) {
        sounds[key] = new Audio(soundPaths[key]);
    }

    function playSound(soundName, volume = 1) {
        const sound = sounds[soundName];
        if (!sound) return;

        sound.volume = volume;
        sound.currentTime = 0;
        sound.play();
    }

    
    if (buttons.open) {
        buttons.open.addEventListener('click', () => playSound('open'));
    } else {
        console.warn('Botão ".add-button" não encontrado.');
    }

    if (buttons.create) {
        buttons.create.addEventListener('click', () => playSound('create'));
    } else {
        console.warn('Botão ".createItem-button" não encontrado.');
    }

    if (buttons.delete) {
        buttons.delete.addEventListener('click', () => playSound('delete'));
    } else {
        console.warn('Botão ".deleteItem-button" não encontrado.');
    }
});

document.addEventListener('submit', function (e) {
    if (e.target.classList.contains('delete-form')) {
        if (!confirm('Tem certeza que deseja deletar este item?')) {
            e.preventDefault(); 
        }
    }
});
