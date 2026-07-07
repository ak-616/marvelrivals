document.getElementById('loadBtn').addEventListener('click', async () => {
    const output = document.getElementById('output');
    output.textContent = 'Loading...';

    try {
        const response = await fetch('/api/proxy/heroes');
        if (!response.ok) {
            throw new Error(`Server responded with ${response.status}`);
        }
        const names = await response.json();
        output.textContent = names.join('\n');
    } catch (err) {
        output.textContent = 'Error: ' + err.message;
    }
});