window.workflowDesigner = window.workflowDesigner || {};

window.workflowDesigner.setDragData = function(event, data) {
    event.dataTransfer.setData('text/plain', JSON.stringify(data));
    event.dataTransfer.effectAllowed = 'copy';
};

window.workflowDesigner.getDragData = function(event) {
    try {
        const data = event.dataTransfer.getData('text/plain');
        return data ? JSON.parse(data) : null;
    } catch (e) {
        return null;
    }
};

window.workflowDesigner.preventDefault = function(event) {
    event.preventDefault();
    event.dataTransfer.dropEffect = 'copy';
};
