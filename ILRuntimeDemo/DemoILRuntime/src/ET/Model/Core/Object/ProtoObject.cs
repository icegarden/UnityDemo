namespace ET
{
    public interface ISupportInitialize
    {
        void BeginInit();
        void EndInit();
    }

    public interface IDisposable
    {
        void Dispose();
    }
    
    
    public abstract class DisposeObject: Object, IDisposable, ISupportInitialize
    {
        public virtual void Dispose()
        {
        }
        
        public virtual void BeginInit()
        {
        }
        
        public virtual void EndInit()
        {
        }
        
        public override string ToString()
        {
            return this.GetType().Name;

        }
    }
}