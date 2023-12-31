package clase;

import javax.swing.*;
import java.awt.*;
import java.util.List;


public class AsyncTaskSwing<T, V> extends SwingWorker<T, V> {
    private final JProgressBar progressBar;
    private final JLabel progressLabel;
    private final List<T> data;

    public AsyncTaskSwing(JProgressBar progressBar, JLabel progressLabel, List<T> data) {
        this.progressBar = progressBar;
        this.progressLabel = progressLabel;
        this.data = data;
    }

    @Override
    protected T doInBackground() throws Exception {
        int progress = 0;
        int dataSize = data.size();

        for (T item : data) {
            // Simula el procesamiento de cada elemento en la lista
            // Puedes reemplazar esta lógica con tu propia tarea
            Thread.sleep(500);

            // Actualiza el progreso
            progress = (int) ((double) (data.indexOf(item) + 1) / dataSize * 100);
            setProgress(progress);
            
            
        }

        return null;
    }

    @Override
    protected void process(List<V> chunks) {
        // Este método se llama en el hilo de despacho de eventos de Swing
        // Actualiza la interfaz de usuario mientras se ejecuta la tarea en segundo plano
        progressLabel.setText("Progreso: " + chunks.get(chunks.size() - 1) + "%");
    }

    @Override
    protected void done() {
        // Este método se llama cuando la tarea en segundo plano ha terminado
        progressBar.setValue(100);
        progressLabel.setText("Proceso completado");
    }

    public static void main(String[] args) {
        // Crear y mostrar la ventana
        SwingUtilities.invokeLater(() -> {
            createAndShowGUI();
        });
    }

    private static void createAndShowGUI() {
        JFrame frame = new JFrame("SwingWorker Example");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(300, 150);
        frame.setLayout(new BorderLayout());

        JProgressBar progressBar = new JProgressBar(0, 100);
        progressBar.setStringPainted(true);

        JLabel progressLabel = new JLabel("Progreso: 0%");

        JButton startButton = new JButton("Iniciar Tarea");
        startButton.addActionListener(e -> {
            // Lista de datos de ejemplo
            java.util.List<String> data = List.of("Item 1", "Item 2", "Item 3", "Item 4", "Item 5");

            // Crear una instancia de AsyncTaskSwing y ejecutarla
            AsyncTaskSwing<String, Void> asyncTask = new AsyncTaskSwing<>(progressBar, progressLabel, data);
            asyncTask.execute();
            
        });

        JPanel panel = new JPanel();
        panel.add(startButton);

        frame.add(progressBar, BorderLayout.NORTH);
        frame.add(progressLabel, BorderLayout.CENTER);
        frame.add(panel, BorderLayout.SOUTH);

        frame.setVisible(true);
    }
}
