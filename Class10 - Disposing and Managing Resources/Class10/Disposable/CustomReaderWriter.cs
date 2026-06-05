internal class OurWriter : IDisposable
{
    private string _path;
    private readonly StreamWriter _writer; 
    private bool _disposed;

    public OurWriter(string filePath)
    {
        _path = filePath;
        _writer = new StreamWriter(filePath, append: true);
    }

    public void Write(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Text cannot be null or empty.");
        }
        if (_disposed)
        {
            throw new ObjectDisposedException("OurWriter is disposed.");
        }
        _writer.Write(text);
    }

    private void Dispose (bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _writer.Dispose();
            }
            _path = string.Empty;
            _disposed = true;
        }
    }


    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}

internal class OurReader : IDisposable
{
    private string _path;
    private readonly StreamReader _reader;
    private bool _disposed;

    public OurReader(string filePath)
    {
        _path = filePath;
        _reader = new StreamReader(filePath);
    }

    public void Read()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException("OurReader is disposed.");
        }
        _reader.ReadToEnd();
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _reader.Dispose();
            }
            _path = string.Empty;
            _disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}