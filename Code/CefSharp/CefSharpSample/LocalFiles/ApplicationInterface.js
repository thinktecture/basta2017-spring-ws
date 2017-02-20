
window.applicationInterface = {
    addMessage: function(text) {
        var container = document.getElementById('interface-area'),
            messageNode = document.createElement('p');

        messageNode.appendChild(document.createTextNode(text));

        container.appendChild(messageNode);
    },

    loadText: function() {
        var element = document.getElementById('retrieve-text');

        return element.value;
    },

    showMessage: function () {
        window.appHost.showMessage(document.getElementById('apphost-message').value);
    }
};