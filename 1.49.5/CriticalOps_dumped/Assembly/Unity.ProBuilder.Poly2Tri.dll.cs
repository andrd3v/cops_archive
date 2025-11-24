// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class Polygon
{
	// Fields
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> _points; // 0x10
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> _steinerPoints; // 0x18
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.Polygon> _holes; // 0x20
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> _triangles; // 0x28

	// Methods

	// RVA: 0x14D708C
	public void .ctor(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x14D7474
	public void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x14D7528
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x14D7530
	public void AddHole(Polygon poly) { }

	// RVA: 0x14D75E8
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x14D75F0
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x14D7654
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x14D76B8
	public void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonPoint
{
	// Methods

	// RVA: 0x14D7BD8
	public void .ctor(Double x, Double y, int index) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DelaunayTriangle
{
	// Fields
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> Points; // 0x10
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> Neighbors; // 0x28
	public FixedBitArray3 EdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	private bool <IsInterior>k__BackingField; // 0x46

	// Methods

	// RVA: 0x14D7C58
	public bool get_IsInterior() { }

	// RVA: 0x14D7C60
	public void set_IsInterior(bool value) { }

	// RVA: 0x14D7C68
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0x14D7D10
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x14D7DC0
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x14D7DF8
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x14D7E54
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x14D809C
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x14D82CC
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14D8458
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x14D8504
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x14D85B0
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x14D863C
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x14D83CC
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x14D86C8
	private void RotateCW() { }

	// RVA: 0x14D8798
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x14D883C
	public override string ToString() { }

	// RVA: 0x14D89FC
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x14D8B10
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x14D7FA8
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x14D8BEC
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x14D8D24
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x14D8DE0
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14D8EA0
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14D8F60
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x14D901C
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x14D90D8
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14D9198
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFront
{
	// Fields
	public AdvancingFrontNode Head; // 0x10
	public AdvancingFrontNode Tail; // 0x18
	protected AdvancingFrontNode Search; // 0x20

	// Methods

	// RVA: 0x14D9258
	public void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0x14D92B8
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x14D92BC
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x14D92C0
	public override string ToString() { }

	// RVA: 0x14D93BC
	private AdvancingFrontNode FindSearchNode(Double x) { }

	// RVA: 0x14D93C4
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x14D9454
	private AdvancingFrontNode LocateNode(Double x) { }

	// RVA: 0x14D94DC
	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFrontNode
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public Double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Methods

	// RVA: 0x14D95E0
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x14D9628
	public bool get_HasNext() { }

	// RVA: 0x14D9638
	public bool get_HasPrev() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal static class DTSweep
{
	// Methods

	// RVA: 0x14D9648
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x14D99E0
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x14D9EA4
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x14DAA98
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x14D9D10
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x14DA550
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x14DBE44
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x14DA800
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DC8E8
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DD07C
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DD1E0
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DD390
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DCCD0
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DD638
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DD7DC
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DD938
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DCEA8
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14DC704
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x14DC918
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x14DDC40
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14DE708
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0x14DE50C
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x14DE8E4
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14DC0FC
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x14DEF00
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14DF114
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14DF2F0
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14DED94
	private static Double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x14DEE64
	private static Double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x14DBBF4
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14DC204
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x14DAC9C
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepBasin
{
	// Fields
	public AdvancingFrontNode leftNode; // 0x10
	public AdvancingFrontNode bottomNode; // 0x18
	public AdvancingFrontNode rightNode; // 0x20
	public Double width; // 0x28
	public bool leftHighest; // 0x30

	// Methods

	// RVA: 0x14DF448
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepConstraint
{
	// Methods

	// RVA: 0x14DF450
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepContext
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	private TriangulationPoint <Head>k__BackingField; // 0x50
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Methods

	// RVA: 0x14DF5D0
	public TriangulationPoint get_Head() { }

	// RVA: 0x14DF5D8
	public void set_Head(TriangulationPoint value) { }

	// RVA: 0x14DF5E0
	public TriangulationPoint get_Tail() { }

	// RVA: 0x14DF5E8
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x14DF5F0
	public void .ctor() { }

	// RVA: 0x14DF7E8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x14DB8D0
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x14DBDA8
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x14DF7F0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x14DF960
	public override void Clear() { }

	// RVA: 0x14DC0E0
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x14DF360
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x14DBDAC
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x14D96B4
	public void CreateAdvancingFront() { }

	// RVA: 0x14DB624
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x14DFABC
	public override void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0x14DB934
	public void FinalizeTriangulation() { }

	// RVA: 0x14DFF1C
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepDebugContext
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Methods

	// RVA: 0x14DC6A0
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x14DE428
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x14DFF88
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x14DBA74
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x14DA79C
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x14DFFEC
	public override void Clear() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepEdgeEvent
{
	// Fields
	public DTSweepConstraint ConstrainedEdge; // 0x10
	public bool Right; // 0x18

	// Methods

	// RVA: 0x14DF6F8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepPointComparator
{
	// Methods

	// RVA: 0x14E0134
	public int Compare(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x14DF700
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointOnEdgeException
{
	// Fields
	public readonly TriangulationPoint A; // 0x90
	public readonly TriangulationPoint B; // 0x98
	public readonly TriangulationPoint C; // 0xA0

	// Methods

	// RVA: 0x14DDBDC
	public void .ctor(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal interface Triangulatable
{
	// Methods

	// RVA: -1
	public abstract void Prepare(TriangulationContext tcx) { }

	// RVA: -1
	public abstract System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: -1
	public abstract void AddTriangle(DelaunayTriangle t) { }

	// RVA: -1
	public abstract void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: -1
	public abstract TriangulationMode get_TriangulationMode() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum Orientation
{
	// Fields
	public int value__; // 0x10
	public const Orientation CW = 0;
	public const Orientation CCW = 1;
	public const Orientation Collinear = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointSet
{
	// Fields
	private System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> <Points>k__BackingField; // 0x10
	private System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> <Triangles>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14E01A0
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> get_Points() { }

	// RVA: 0x14E01A8
	private void set_Points(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> value) { }

	// RVA: 0x14E01B0
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x14E01B8
	private void set_Triangles(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> value) { }

	// RVA: 0x14E01C0
	public void .ctor(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> points) { }

	// RVA: 0x14E025C
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x14E0264
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x14E031C
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x14E0660
	public virtual void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationConstraint
{
	// Fields
	public TriangulationPoint P; // 0x10
	public TriangulationPoint Q; // 0x18

	// Methods

	// RVA: 0x14DF510
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationContext
{
	// Fields
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x10
	public readonly System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> Triangles; // 0x18
	public readonly System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> Points; // 0x20
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	private Triangulatable <Triangulatable>k__BackingField; // 0x30
	private int <StepCount>k__BackingField; // 0x38
	private bool <IsDebugEnabled>k__BackingField; // 0x3C

	// Methods

	// RVA: 0x14E082C
	public TriangulationDebugContext get_DebugContext() { }

	// RVA: 0x14E0834
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x14E083C
	protected void set_TriangulationMode(TriangulationMode value) { }

	// RVA: 0x14E0844
	public Triangulatable get_Triangulatable() { }

	// RVA: 0x14E084C
	private void set_Triangulatable(Triangulatable value) { }

	// RVA: 0x14E0854
	public int get_StepCount() { }

	// RVA: 0x14E085C
	private void set_StepCount(int value) { }

	// RVA: 0x14DA540
	public void Done() { }

	// RVA: 0x14DFDFC
	public virtual void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0x14DAA94
	public void Update(string message) { }

	// RVA: 0x14DFA08
	public virtual void Clear() { }

	// RVA: 0x14E0864
	public virtual bool get_IsDebugEnabled() { }

	// RVA: 0x14DA714
	public DTSweepDebugContext get_DTDebugContext() { }

	// RVA: 0x14DF708
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationDebugContext
{
	// Fields
	protected TriangulationContext _tcx; // 0x10

	// Methods

	// RVA: -1
	public abstract void Clear() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum TriangulationMode
{
	// Fields
	public int value__; // 0x10
	public const TriangulationMode Unconstrained = 0;
	public const TriangulationMode Constrained = 1;
	public const TriangulationMode Polygon = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationPoint
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> <Edges>k__BackingField; // 0x10
	public Double X; // 0x18
	public Double Y; // 0x20
	public int Index; // 0x28

	// Methods

	// RVA: 0x14E086C
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> get_Edges() { }

	// RVA: 0x14E0874
	private void set_Edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> value) { }

	// RVA: 0x14D7C18
	public void .ctor(Double x, Double y, int index) { }

	// RVA: 0x14E087C
	public override string ToString() { }

	// RVA: 0x14DF518
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x14DA704
	public bool get_HasEdges() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationUtil
{
	// Fields
	public static Double EPSILON; // 0x0

	// Methods

	// RVA: 0x14DF37C
	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x14DE48C
	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x14DBAD8
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc) { }

	// RVA: 0x14E09D8
	private static void .cctor() { }

}

// Namespace: 
private sealed class <Enumerate>d__10
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<T> <>4__this; // 0x0
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<T> <>3__<>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Methods

	// RVA: 0x30B29E8
	public void .ctor(int <>1__state) { }

	// RVA: 0x30B2870
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30B171C
	private bool MoveNext() { }

	// RVA: 0x316B894
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal struct FixedArray3<T0>
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Methods

	// RVA: 0x316B894
	public T get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, T value) { }

	// RVA: 0x316B894
	public bool Contains(T value) { }

	// RVA: 0x316B894
	public int IndexOf(T value) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerable<T> Enumerate() { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <Enumerate>d__10
{
	// Fields
	private int <>1__state; // 0x10
	private bool <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	public FixedBitArray3 <>4__this; // 0x1C
	public FixedBitArray3 <>3__<>4__this; // 0x1F
	private int <i>5__2; // 0x24

	// Methods

	// RVA: 0x14E0ABC
	public void .ctor(int <>1__state) { }

	// RVA: 0x14E0C0C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x14E0C10
	private bool MoveNext() { }

	// RVA: 0x14E0CDC
	private bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current() { }

	// RVA: 0x14E0CE4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x14E0D24
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x14E0D8C
	private System.Collections.Generic.IEnumerator<System.Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

	// RVA: 0x14E0E34
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal struct FixedBitArray3
{
	// Fields
	public bool _0; // 0x10
	public bool _1; // 0x11
	public bool _2; // 0x12

	// Methods

	// RVA: 0x14D8CA8
	public bool get_Item(int index) { }

	// RVA: 0x14D8A98
	public void set_Item(int index, bool value) { }

	// RVA: 0x14DED88
	public void Clear() { }

	// RVA: 0x14E0A34
	private System.Collections.Generic.IEnumerable<System.Boolean> Enumerate() { }

	// RVA: 0x14E0AF4
	public System.Collections.Generic.IEnumerator<System.Boolean> GetEnumerator() { }

	// RVA: 0x14E0C08
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


