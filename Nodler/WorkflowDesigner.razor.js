export function setDragData(event, data) {
    event.dataTransfer.setData('text/plain', JSON.stringify(data));
    event.dataTransfer.effectAllowed = 'copy';
}

export function getDragData(event) {
    try {
        const data = event.dataTransfer.getData('text/plain');
        return data ? JSON.parse(data) : null;
    } catch (e) {
        return null;
    }
}

export function preventDefault(event) {
    event.preventDefault();
    event.dataTransfer.dropEffect = 'copy';
}

export function getBoundingClientRect(element) {
    const rect = element.getBoundingClientRect();
    return { x: rect.x, y: rect.y, width: rect.width, height: rect.height };
}
