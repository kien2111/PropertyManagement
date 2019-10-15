using QuanLyPhongTro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.Common
{
    public class FrameNavigator:INavigationService
    {
        private readonly IStack<IMyFrame> _historyFrame = new StackLinkedList<IMyFrame>();
        
        private readonly IHostNavigator _hostNavigator;
        private readonly object[] _availableFrame;
        private IMyFrame _currentFrame;
        public FrameNavigator(IHostNavigator hostNavigator,object[] AvailableFrames) : base()
        {
            if (hostNavigator == null) throw new ArgumentNullException("Not supply IHostnavitor");
            if (AvailableFrames == null || AvailableFrames.Count() <= 0) throw new ArgumentNullException("Not supply available collection frame or don't have any frame in collection");
            _hostNavigator = hostNavigator;
            _availableFrame = AvailableFrames;
            _currentFrame = null;
        }

        public IMyFrame CurrentFrame { get { return _currentFrame; } }

        public void BackWard()
        {
            IMyFrame prevFrame = _historyFrame.pop();
            if (prevFrame == null) return;
            _currentFrame = prevFrame;
            applyFrameToWindow(_currentFrame);            
        }

        

        private void applyFrameToWindow(IMyFrame frame)
        {
            _hostNavigator.ActiveFrameIndex = frame.IndexOfFrame;
        }

        public void GoTo(int indexOfAvailableCollectionFrame)
        {
            GoTo(indexOfAvailableCollectionFrame, () => { });
        }

        public void GoTo(int indexOfAvailableCollectionFrame, Action actionBeforeGoTo)
        {
            if (_currentFrame == null)
            {
                _currentFrame = new AvailableFrame(indexOfAvailableCollectionFrame,actionBeforeGoTo);
                applyFrameToWindow(_currentFrame);
            }
            else
            {
                if(_currentFrame.IndexOfFrame == indexOfAvailableCollectionFrame)//go to same current frame ignore
                {
                    return;
                }
                else
                {
                    _historyFrame.push(_currentFrame);//push current frame
                    _currentFrame = new AvailableFrame(indexOfAvailableCollectionFrame, actionBeforeGoTo);//pointer current frame to new instance
                    applyFrameToWindow(_currentFrame);

                }                
            }
        }
    }
}
